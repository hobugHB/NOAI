using NOAI.l0Connection;
using NOAI_System__Text_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System__ComponentModel_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;

namespace NOAI_System__Text_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00
{
	/// 
	//[System.Runtime.CompilerServices.NullableContextAttribute(0)]
	[NOAI_l0Connection_ConnGenAttribute(
TypeInfoJson="{\"$id\":\"1\",\"ContextGuid\":\"00000000-0000-0000-0000-000000000000\",\"ContextDate\":\"0001-01-01T00:00:00\",\"AssemblyName\":null,\"Namespace\":\"System.Text\",\"IsPublic\":false,\"IsStatic\":false,\"Name\":\"ChunkEnumerator\",\"IsPrimitive\":false,\"IsSealed\":true,\"IsVisible\":true,\"IsValueType\":true,\"GUID\":\"dd3e085e-e273-32c5-8b8e-d67f6cae2a6f\",\"Attributes\":1048842,\"HasElementType\":false,\"IsGenericMethodParameter\":false,\"IsGenericParameter\":false,\"IsGenericType\":false,\"IsGenericTypeDefinition\":false,\"IsGenericTypeParameter\":false,\"GenericParameterAttributes\":0,\"GenericParameterPosition\":0,\"GenericTypeArguments\":[],\"IsAbstract\":false,\"IsAnsiClass\":true,\"IsArray\":false,\"IsAutoClass\":false,\"IsAutoLayout\":false,\"IsByRef\":false,\"IsByRefLike\":false,\"IsClass\":false,\"IsCOMObject\":false,\"IsConstructedGenericType\":false,\"IsContextful\":false,\"IsEnum\":false,\"IsExplicitLayout\":false,\"IsImport\":false,\"IsInterface\":false,\"IsLayoutSequential\":true,\"IsMarshalByRef\":false,\"IsNested\":true,\"IsNestedAssembly\":false,\"IsNestedFamANDAssem\":false,\"IsNestedFamily\":false,\"IsNestedFamORAssem\":false,\"IsNestedPrivate\":false,\"IsNestedPublic\":true,\"IsNotPublic\":false,\"IsPointer\":false,\"IsSecurityCritical\":true,\"IsSecuritySafeCritical\":false,\"IsSecurityTransparent\":false,\"IsSerializable\":false,\"IsSignatureType\":false,\"IsSpecialName\":false,\"IsSZArray\":false,\"IsTypeDefinition\":true,\"IsUnicodeClass\":false,\"IsVariableBoundArray\":false,\"AssemblyProperties\":{\"$id\":\"2\",\"Name\":\"System.Private.CoreLib\",\"Version\":\"6.0.0.0\",\"FullName\":\"System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e\",\"CodeBase\":\"file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Private.CoreLib.dll\",\"EscapedCodeBase\":\"file:///C:/Program%20Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Private.CoreLib.dll\",\"VersionCompatibility\":1,\"ContentType\":0,\"CultureName\":\"\",\"Flags\":1,\"HashAlgorithm\":32772,\"KeyPair\":null,\"ProcessorArchitecture\":4}}" 
)]
	public /*static*/ struct ChunkEnumerator
	{
		private /*static*/ System.Text.ChunkEnumerator _NOAI_l0Connection_UnderlyingTypeBaseInstance;

		public /*static*/ ChunkEnumerator(System.Text.StringBuilder+ChunkEnumerator NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance;
		}

		public /*static*/ System.Text.StringBuilder+ChunkEnumerator NOAI_l0Connection_UnderlyingTypeBaseInstance
		{ get { return _NOAI_l0Connection_UnderlyingTypeBaseInstance; } }

		/// 
		public /*static*/ ReadOnlyMemory<System.Char> Current
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new ReadOnlyMemory<System.Char>(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Current)); }
		}

		/// 
		[System.ComponentModel.EditorBrowsableAttribute(1)]
		[EditorBrowsableAttribute(1)]
		public /*static*/ /*async*/ ChunkEnumerator GetEnumerator(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new ChunkEnumerator(_NOAI_l0Connection_UnderlyingTypeBaseInstance.GetEnumerator(
					)));
		}

		/// 
		public /*static*/ /*async*/ System.Boolean MoveNext(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.MoveNext(
					));
		}

		public override int GetHashCode()
		{
			return _NOAI_l0Connection_UnderlyingTypeBaseInstance.GetHashCode();
		}

	}
}

