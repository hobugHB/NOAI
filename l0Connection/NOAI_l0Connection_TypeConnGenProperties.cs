using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NOAI.l0Connection
{
    public class NOAI_l0Connection_TypeConnGenProperties
    {
        public DateTime ContextDate { get; set; }

        public object Namespace { get; set; }
        public object IsPublic { get; set; }
        public bool IsStatic { get; set; }
        public object Name { get; set; }

        public object IsPrimitive { get; set; }
        public object IsSealed { get; set; }
        public object IsVisible { get; set; }

        public object IsValueType { get; set; }

        public object GUID { get; set; }
        public object Attributes { get; set; }
        public object HasElementType { get; set; }

        public object IsGenericMethodParameter { get; set; }
        public object IsGenericParameter { get; set; }
        public object IsGenericType { get; set; }
        public object IsGenericTypeDefinition { get; set; }
        public object IsGenericTypeParameter { get; set; }

        public object GenericParameterAttributes { get; set; }
        public object GenericParameterPosition { get; set; }
        public object GenericTypeArguments { get; set; }
        //public object GenericTypeParameters  { get; set; }

        public object IsAbstract { get; set; }
        public object IsAnsiClass { get; set; }
        public object IsArray { get; set; }
        public object IsAutoClass { get; set; }
        public object IsAutoLayout { get; set; }
        public object IsByRef { get; set; }
        public object IsByRefLike { get; set; }
        public object IsClass { get; set; }
        public object IsCOMObject { get; set; }
        public object IsConstructedGenericType { get; set; }
        public object IsContextful { get; set; }
        public object IsEnum { get; set; }
        public object IsExplicitLayout { get; set; }

        public object IsImport { get; set; }
        public object IsInterface { get; set; }
        public object IsLayoutSequential { get; set; }
        public object IsMarshalByRef { get; set; }

        public object IsNested { get; set; }
        public object IsNestedAssembly { get; set; }
        public object IsNestedFamANDAssem { get; set; }
        public object IsNestedFamily { get; set; }
        public object IsNestedFamORAssem { get; set; }
        public object IsNestedPrivate { get; set; }
        public object IsNestedPublic { get; set; }

        public object IsNotPublic { get; set; }
        public object IsPointer { get; set; }
        public object IsSecurityCritical { get; set; }
        public object IsSecuritySafeCritical { get; set; }
        public object IsSecurityTransparent { get; set; }
        public object IsSerializable { get; set; }
        public object IsSignatureType { get; set; }
        public object IsSpecialName { get; set; }
        public object IsSZArray { get; set; }
        public object IsTypeDefinition { get; set; }
        public object IsUnicodeClass { get; set; }
        public object IsVariableBoundArray { get; set; }

        public object AssemblyName { get; set; }

        public NOAI_l0Connection_TypeConnGenProperties(TypeInfo typeInfo)
        {
            var typeAssemblyName = typeInfo.Assembly.GetName();

            this.Namespace = ExtractValue(() => typeInfo.Namespace ?? "");
            this.IsPublic = ExtractValue(() => typeInfo.IsPublic);
            this.IsStatic = typeInfo.IsAbstract && typeInfo.IsSealed;
            this.Name = ExtractValue(() => typeInfo.Name);

            this.IsPrimitive = ExtractValue(() => typeInfo.IsPrimitive);
            this.IsSealed = ExtractValue(() => typeInfo.IsSealed);
            this.IsVisible = ExtractValue(() => typeInfo.IsVisible);

            this.IsValueType = ExtractValue(() => typeInfo.IsValueType);

            this.GUID = ExtractValue(() => typeInfo.GUID);
            this.Attributes = ExtractValue(() => typeInfo.Attributes);
            this.HasElementType = ExtractValue(() => typeInfo.HasElementType);

            this.IsGenericMethodParameter = ExtractValue(() => typeInfo.IsGenericMethodParameter);
            this.IsGenericParameter = ExtractValue(() => typeInfo.IsGenericParameter);
            this.IsGenericType = ExtractValue(() => typeInfo.IsGenericType);
            this.IsGenericTypeDefinition = ExtractValue(() => typeInfo.IsGenericTypeDefinition);
            this.IsGenericTypeParameter = ExtractValue(() => typeInfo.IsGenericTypeParameter);

            this.GenericParameterAttributes = ExtractValue(() => typeInfo.GenericParameterAttributes);
            this.GenericParameterPosition = ExtractValue(() => typeInfo.GenericParameterPosition);
            this.GenericTypeArguments = ExtractValue(() => typeInfo.GenericTypeArguments);
            //this.GenericTypeParameters = ExtractValue(() => typeInfo.GenericTypeParameters);

            this.IsAbstract = ExtractValue(() => typeInfo.IsAbstract);
            this.IsAnsiClass = ExtractValue(() => typeInfo.IsAnsiClass);
            this.IsArray = ExtractValue(() => typeInfo.IsArray);
            this.IsAutoClass = ExtractValue(() => typeInfo.IsAutoClass);
            this.IsAutoLayout = ExtractValue(() => typeInfo.IsAutoLayout);
            this.IsByRef = ExtractValue(() => typeInfo.IsByRef);
            this.IsByRefLike = ExtractValue(() => typeInfo.IsByRefLike);
            this.IsClass = ExtractValue(() => typeInfo.IsClass);
            this.IsCOMObject = ExtractValue(() => typeInfo.IsCOMObject);
            this.IsConstructedGenericType = ExtractValue(() => typeInfo.IsConstructedGenericType);
            this.IsContextful = ExtractValue(() => typeInfo.IsContextful);
            this.IsEnum = ExtractValue(() => typeInfo.IsEnum);
            this.IsExplicitLayout = ExtractValue(() => typeInfo.IsExplicitLayout);

            this.IsImport = ExtractValue(() => typeInfo.IsImport);
            this.IsInterface = ExtractValue(() => typeInfo.IsInterface);
            this.IsLayoutSequential = ExtractValue(() => typeInfo.IsLayoutSequential);
            this.IsMarshalByRef = ExtractValue(() => typeInfo.IsMarshalByRef);

            this.IsNested = ExtractValue(() => typeInfo.IsNested);
            this.IsNestedAssembly = ExtractValue(() => typeInfo.IsNestedAssembly);
            this.IsNestedFamANDAssem = ExtractValue(() => typeInfo.IsNestedFamANDAssem);
            this.IsNestedFamily = ExtractValue(() => typeInfo.IsNestedFamily);
            this.IsNestedFamORAssem = ExtractValue(() => typeInfo.IsNestedFamORAssem);
            this.IsNestedPrivate = ExtractValue(() => typeInfo.IsNestedPrivate);
            this.IsNestedPublic = ExtractValue(() => typeInfo.IsNestedPublic);

            this.IsNotPublic = ExtractValue(() => typeInfo.IsNotPublic);
            this.IsPointer = ExtractValue(() => typeInfo.IsPointer);
            this.IsSecurityCritical = ExtractValue(() => typeInfo.IsSecurityCritical);
            this.IsSecuritySafeCritical = ExtractValue(() => typeInfo.IsSecuritySafeCritical);
            this.IsSecurityTransparent = ExtractValue(() => typeInfo.IsSecurityTransparent);
            this.IsSerializable = ExtractValue(() => typeInfo.IsSerializable);
            this.IsSignatureType = ExtractValue(() => typeInfo.IsSignatureType);
            this.IsSpecialName = ExtractValue(() => typeInfo.IsSpecialName);
            this.IsSZArray = ExtractValue(() => typeInfo.IsSZArray);
            this.IsTypeDefinition = ExtractValue(() => typeInfo.IsTypeDefinition);
            this.IsUnicodeClass = ExtractValue(() => typeInfo.IsUnicodeClass);
            this.IsVariableBoundArray = ExtractValue(() => typeInfo.IsVariableBoundArray);

            //this.MemberTypes = ExtractValue(() => typeInfo.MemberType);
            //this.Module = ExtractValue(() => typeInfo.Module);
            //this.ReflectedType = ExtractValue(() => typeInfo.ReflectedType);
            //this.StructLayoutAttribute = ExtractValue(() => typeInfo.StructLayoutAttribute);
            //this.TypeHandle = ExtractValue(() => typeInfo.TypeHandle);
            //this.TypeInitializer = ExtractValue(() => typeInfo.TypeInitializer);
            //this.UnderlyingSystemType = ExtractValue(() => typeInfo.UnderlyingSystemType);

            this.AssemblyName = new
            {
                Name = ExtractValue(() => typeAssemblyName.Name),
                Version = ExtractValue(() => typeAssemblyName.Version),
                FullName = ExtractValue(() => typeAssemblyName.FullName),
                CodeBase = ExtractValue(() => typeAssemblyName.CodeBase),
                EscapedCodeBase = ExtractValue(() => typeAssemblyName.EscapedCodeBase),
                VersionCompatibility = ExtractValue(() => typeAssemblyName.VersionCompatibility),

                ContentType = ExtractValue(() => typeAssemblyName.ContentType),
                //too large too slow
                //CultureInfo = ExtractValue(() => typeAssemblyName.CultureInfo),
                CultureName = ExtractValue(() => typeAssemblyName.CultureName),

                Flags = ExtractValue(() => typeAssemblyName.Flags),
                HashAlgorithm = ExtractValue(() => typeAssemblyName.HashAlgorithm),
                KeyPair = ExtractValue(() => typeAssemblyName.KeyPair),
                ProcessorArchitecture = ExtractValue(() => typeAssemblyName.ProcessorArchitecture),

            };
        }

        private object ExtractValue<T>(Func<T> extract)
        {
            try
            {
                return extract();
            }
            catch
            {
                return null;
            }
        }

    }
}
