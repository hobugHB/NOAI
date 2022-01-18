using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace NOAI.l0Connection
{
    public class ConnGenContext
    {
        public string Output { get; set; } = "";

        public string CodeRefNamespace()
        {
            var builder = new StringBuilder();
            builder.Append("using NOAI.l0Connection;");
            return builder.ToString();
        }

        private object ExtractValue<T>(Func<T> extract)
        {
            if(typeof(T) == typeof(string))
            {

            }
            else
            {
                return null;
            }

            try
            {
                return extract();
            }
            catch
            {
                return null;
            }
        }

        public string CodeConnGenAttribute(TypeInfo typeInfo)
        {
            var builder = new StringBuilder();
            var errors = new List<Exception>();

            var typeAssemblyName = typeInfo.Assembly.GetName();
            builder.Append(
                "[ConnGen(\r\n" +
                    "TypeInfoJson:\"" + JsonSerializer.Serialize(new
                    {
                        Namespace = ExtractValue(() => typeInfo.Namespace ?? ""),

                        IsPrimitive = ExtractValue(() => typeInfo.IsPrimitive),
                        IsPublic = ExtractValue(() => typeInfo.IsPublic),
                        IsSealed = ExtractValue(() => typeInfo.IsSealed),
                        IsVisible = ExtractValue(() => typeInfo.IsVisible),

                        IsValueType = ExtractValue(() => typeInfo.IsValueType),

                        GUID = ExtractValue(() => typeInfo.GUID),
                        Attributes = ExtractValue(() => typeInfo.Attributes),
                        HasElementType = ExtractValue(() => typeInfo.HasElementType),

                        IsGenericMethodParameter = ExtractValue(() => typeInfo.IsGenericMethodParameter),
                        IsGenericParameter = ExtractValue(() => typeInfo.IsGenericParameter),
                        IsGenericType = ExtractValue(() => typeInfo.IsGenericType),
                        IsGenericTypeDefinition = ExtractValue(() => typeInfo.IsGenericTypeDefinition),
                        IsGenericTypeParameter = ExtractValue(() => typeInfo.IsGenericTypeParameter),

                        GenericParameterAttributes = ExtractValue(() => typeInfo.GenericParameterAttributes),
                        GenericParameterPosition = ExtractValue(() => typeInfo.GenericParameterPosition),
                        GenericTypeArguments = ExtractValue(() => typeInfo.GenericTypeArguments),
                        //GenericTypeParameters = ExtractValue(() => typeInfo.GenericTypeParameters),

                        IsAbstract = ExtractValue(() => typeInfo.IsAbstract),
                        IsAnsiClass = ExtractValue(() => typeInfo.IsAnsiClass),
                        IsArray = ExtractValue(() => typeInfo.IsArray),
                        IsAutoClass = ExtractValue(() => typeInfo.IsAutoClass),
                        IsAutoLayout = ExtractValue(() => typeInfo.IsAutoLayout),
                        IsByRef = ExtractValue(() => typeInfo.IsByRef),
                        IsByRefLike = ExtractValue(() => typeInfo.IsByRefLike),
                        IsClass = ExtractValue(() => typeInfo.IsClass),
                        IsCOMObject = ExtractValue(() => typeInfo.IsCOMObject),
                        IsConstructedGenericType = ExtractValue(() => typeInfo.IsConstructedGenericType),
                        IsContextful = ExtractValue(() => typeInfo.IsContextful),
                        IsEnum = ExtractValue(() => typeInfo.IsEnum),
                        IsExplicitLayout = ExtractValue(() => typeInfo.IsExplicitLayout),


                        IsImport = ExtractValue(() => typeInfo.IsImport),
                        IsInterface = ExtractValue(() => typeInfo.IsInterface),
                        IsLayoutSequential = ExtractValue(() => typeInfo.IsLayoutSequential),
                        IsMarshalByRef = ExtractValue(() => typeInfo.IsMarshalByRef),

                        IsNested = ExtractValue(() => typeInfo.IsNested),
                        IsNestedAssembly = ExtractValue(() => typeInfo.IsNestedAssembly),
                        IsNestedFamANDAssem = ExtractValue(() => typeInfo.IsNestedFamANDAssem),
                        IsNestedFamily = ExtractValue(() => typeInfo.IsNestedFamily),
                        IsNestedFamORAssem = ExtractValue(() => typeInfo.IsNestedFamORAssem),
                        IsNestedPrivate = ExtractValue(() => typeInfo.IsNestedPrivate),
                        IsNestedPublic = ExtractValue(() => typeInfo.IsNestedPublic),

                        IsNotPublic = ExtractValue(() => typeInfo.IsNotPublic),
                        IsPointer = ExtractValue(() => typeInfo.IsPointer),
                        IsSecurityCritical = ExtractValue(() => typeInfo.IsSecurityCritical),
                        IsSecuritySafeCritical = ExtractValue(() => typeInfo.IsSecuritySafeCritical),
                        IsSecurityTransparent = ExtractValue(() => typeInfo.IsSecurityTransparent),
                        IsSerializable = ExtractValue(() => typeInfo.IsSerializable),
                        IsSignatureType = ExtractValue(() => typeInfo.IsSignatureType),
                        IsSpecialName = ExtractValue(() => typeInfo.IsSpecialName),
                        IsSZArray = ExtractValue(() => typeInfo.IsSZArray),
                        IsTypeDefinition = ExtractValue(() => typeInfo.IsTypeDefinition),
                        IsUnicodeClass = ExtractValue(() => typeInfo.IsUnicodeClass),
                        IsVariableBoundArray = ExtractValue(() => typeInfo.IsVariableBoundArray),

                        //MemberTypes = ExtractValue(() => typeInfo.MemberType),
                        //Module = ExtractValue(() => typeInfo.Module),
                        //ReflectedType = ExtractValue(() => typeInfo.ReflectedType),
                        //StructLayoutAttribute = ExtractValue(() => typeInfo.StructLayoutAttribute),
                        //TypeHandle = ExtractValue(() => typeInfo.TypeHandle),
                        //TypeInitializer = ExtractValue(() => typeInfo.TypeInitializer),
                        //UnderlyingSystemType = ExtractValue(() => typeInfo.UnderlyingSystemType),

                        AssemblyName = new
                        {
                            Name = ExtractValue(() => typeAssemblyName.Name),
                        },
                    }).Replace("\"", "\\\"") + "\", \r\n" +
                ")]");
            return builder.ToString();
        }

        public string FixPathSymbol(string path)
        {
            return (path ?? "").Replace(" ", "__").
                Replace(".", "__").Replace(",", "__").
                Replace("=", "__").Replace(":", "__");
        }

        public string FixPathLength(string path, string extension)
        {
            if (string.IsNullOrEmpty(path))
            {
                return extension;
            }

            var maxSubLength = 255 - (extension ?? "").Length;
            var fullPath = Path.GetFullPath(path);

            return fullPath.Substring(0, fullPath.Length < maxSubLength ? fullPath.Length : maxSubLength) + extension;
        }
    }
}
