using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WindowsDesktop.Interop
{
	internal class ComInterfaceAssembly(Assembly compiledAssembly)
	{
		private readonly Dictionary<string, Type> _knownTypes = [];

		internal Type GetType(string typeName)
		{
			if (!this._knownTypes.TryGetValue(typeName, out var type))
			{
				type = this._knownTypes[typeName] = compiledAssembly
					.GetTypes()
					.Single(x => x.Name.Split('.').Last() == typeName);
			}

			return type;
		}

		internal object CreateInstance(Type type, Guid? guidService)
		{
			var shellType = Type.GetTypeFromCLSID(CLSID.ImmersiveShell);
			var shell = (IServiceProvider)Activator.CreateInstance(shellType);

			shell.QueryService(guidService ?? type.GUID, type.GUID, out var ppvObject);

			return ppvObject;
		}

		internal (Type type, object instance) CreateInstance(string comInterfaceName, Guid? guidService)
		{
			var type = this.GetType(comInterfaceName);
			var instance = this.CreateInstance(type, guidService);

			return (type, instance);
		}
	}
}
