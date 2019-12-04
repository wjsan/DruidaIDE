using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using Microsoft.CSharp;
using Newtonsoft.Json;

namespace Common
{
    public class AssemblyDataType
    {
        public static bool Save<T>(T obj, string file, string className, string propertyName)
        {
            try
            {
                var provider = new CSharpCodeProvider();
                var options = new CompilerParameters
                {
                    GenerateExecutable = false,
                    OutputAssembly = $@"{file}"
                };
                var json = JsonConvert.SerializeObject(obj).Replace('"', '_'); //substitui aspas por _ para salvar
                var d0 = $"public static string {propertyName} = @\"{json}\" ; ";
                var classe = $"public class {className} {{ {d0} }}";
                provider.CompileAssemblyFromSource(options, classe);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static T Load<T>(string file, string className, string propertyName) where T : new()
        {
            if (!File.Exists(file)) return new T();
            var cl = Assembly.Load(File.ReadAllBytes($@"{file}")).GetType(className);
            var json = cl.GetField(propertyName).GetValue(null).ToString().Replace('_', '"');
            var obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}
