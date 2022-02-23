using NOAI.l0Connection;

namespace NOAI_System__Reflection_System__Reflection__Metadata____Version__6__0__0__0____Culture__neutral____PublicKeyToken__b03f5f7f11d50a3a_0__00__00
{
	/// <summary>Specifies the hash algorithms used for hashing assembly files and for generating the strong name.</summary>
	[NOAI_l0Connection_ConnGenAttribute(
TypeInfoJson:"{\"$id\":\"1\",\"ContextGuid\":\"00000000-0000-0000-0000-000000000000\",\"ContextDate\":\"0001-01-01T00:00:00\",\"Namespace\":\"System.Reflection\",\"IsPublic\":true,\"IsStatic\":false,\"Name\":\"AssemblyHashAlgorithm\",\"IsPrimitive\":false,\"IsSealed\":true,\"IsVisible\":true,\"IsValueType\":true,\"GUID\":\"5eea36df-4591-3c96-aa87-4efc0891d44a\",\"Attributes\":257,\"HasElementType\":false,\"IsGenericMethodParameter\":false,\"IsGenericParameter\":false,\"IsGenericType\":false,\"IsGenericTypeDefinition\":false,\"IsGenericTypeParameter\":false,\"GenericParameterAttributes\":0,\"GenericParameterPosition\":0,\"GenericTypeArguments\":[],\"IsAbstract\":false,\"IsAnsiClass\":true,\"IsArray\":false,\"IsAutoClass\":false,\"IsAutoLayout\":true,\"IsByRef\":false,\"IsByRefLike\":false,\"IsClass\":false,\"IsCOMObject\":false,\"IsConstructedGenericType\":false,\"IsContextful\":false,\"IsEnum\":true,\"IsExplicitLayout\":false,\"IsImport\":false,\"IsInterface\":false,\"IsLayoutSequential\":false,\"IsMarshalByRef\":false,\"IsNested\":false,\"IsNestedAssembly\":false,\"IsNestedFamANDAssem\":false,\"IsNestedFamily\":false,\"IsNestedFamORAssem\":false,\"IsNestedPrivate\":false,\"IsNestedPublic\":false,\"IsNotPublic\":false,\"IsPointer\":false,\"IsSecurityCritical\":true,\"IsSecuritySafeCritical\":false,\"IsSecurityTransparent\":false,\"IsSerializable\":true,\"IsSignatureType\":false,\"IsSpecialName\":false,\"IsSZArray\":false,\"IsTypeDefinition\":true,\"IsUnicodeClass\":false,\"IsVariableBoundArray\":false,\"AssemblyName\":{\"$id\":\"2\",\"Name\":\"System.Reflection.Metadata\",\"Version\":\"6.0.0.0\",\"FullName\":\"System.Reflection.Metadata, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a\",\"CodeBase\":\"file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Reflection.Metadata.dll\",\"EscapedCodeBase\":\"file:///C:/Program%20Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Reflection.Metadata.dll\",\"VersionCompatibility\":1,\"ContentType\":0,\"CultureName\":\"\",\"Flags\":1,\"HashAlgorithm\":32772,\"KeyPair\":null,\"ProcessorArchitecture\":1}}", 
)]
	public enum AssemblyHashAlgorithm
	{
		/// <summary>
		/// <para>A mask indicating that there is no hash algorithm.</para>
		/// <para>If you specify <see cref="F:System.Reflection.AssemblyHashAlgorithm.None" /> for a multi-module assembly, the common language runtime defaults to the SHA1 algorithm, since multi-module assemblies need to generate a hash.</para>
		/// </summary>
		None = 0,
		/// <summary>
		/// <para>Retrieves the MD5 message-digest algorithm.</para>
		/// <para>Due to collision problems with MD5, Microsoft recommends SHA256.</para>
		/// <para>MD5 was developed by Rivest in 1991. It is basically MD4 with safety-belts and, while it is slightly slower than MD4, it helps provide more security. The algorithm consists of four distinct rounds, which has a slightly different design from that of MD4. Message-digest size, as well as padding requirements, remain the same.</para>
		/// </summary>
		MD5 = 32771,
		/// <summary>
		/// <para>Retrieves a revision of the Secure Hash Algorithm that corrects an unpublished flaw in SHA.</para>
		/// <para>Due to collision problems with SHA1, Microsoft recommends SHA256.</para>
		/// </summary>
		Sha1 = 32772,
		/// <summary>Retrieves a version of the Secure Hash Algorithm with a hash size of 256 bits.</summary>
		Sha256 = 32780,
		/// <summary>Retrieves a version of the Secure Hash Algorithm with a hash size of 384 bits.</summary>
		Sha384 = 32781,
		/// <summary>Retrieves a version of the Secure Hash Algorithm with a hash size of 512 bits.</summary>
		Sha512 = 32782,
	}
}

