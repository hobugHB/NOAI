using NOAI.l0Connection;
using NOAI_System__Threading_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;

namespace NOAI_Microsoft__Win32__SafeHandles_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00
{
	/// 
	[System.Runtime.CompilerServices.NullableContextAttribute(2)]
	[System.Runtime.CompilerServices.NullableAttribute(0)]
	[NOAI_l0Connection_ConnGenAttribute(
TypeInfoJson="{\"$id\":\"1\",\"ContextGuid\":\"00000000-0000-0000-0000-000000000000\",\"ContextDate\":\"0001-01-01T00:00:00\",\"AssemblyName\":null,\"Namespace\":\"Microsoft.Win32.SafeHandles\",\"IsPublic\":true,\"IsStatic\":false,\"Name\":\"SafeFileHandle\",\"IsPrimitive\":false,\"IsSealed\":true,\"IsVisible\":true,\"IsValueType\":false,\"GUID\":\"737e417d-cac6-35ed-9817-2420b20e3fe1\",\"Attributes\":1048833,\"HasElementType\":false,\"IsGenericMethodParameter\":false,\"IsGenericParameter\":false,\"IsGenericType\":false,\"IsGenericTypeDefinition\":false,\"IsGenericTypeParameter\":false,\"GenericParameterAttributes\":0,\"GenericParameterPosition\":0,\"GenericTypeArguments\":[],\"IsAbstract\":false,\"IsAnsiClass\":true,\"IsArray\":false,\"IsAutoClass\":false,\"IsAutoLayout\":true,\"IsByRef\":false,\"IsByRefLike\":false,\"IsClass\":true,\"IsCOMObject\":false,\"IsConstructedGenericType\":false,\"IsContextful\":false,\"IsEnum\":false,\"IsExplicitLayout\":false,\"IsImport\":false,\"IsInterface\":false,\"IsLayoutSequential\":false,\"IsMarshalByRef\":false,\"IsNested\":false,\"IsNestedAssembly\":false,\"IsNestedFamANDAssem\":false,\"IsNestedFamily\":false,\"IsNestedFamORAssem\":false,\"IsNestedPrivate\":false,\"IsNestedPublic\":false,\"IsNotPublic\":false,\"IsPointer\":false,\"IsSecurityCritical\":true,\"IsSecuritySafeCritical\":false,\"IsSecurityTransparent\":false,\"IsSerializable\":false,\"IsSignatureType\":false,\"IsSpecialName\":false,\"IsSZArray\":false,\"IsTypeDefinition\":true,\"IsUnicodeClass\":false,\"IsVariableBoundArray\":false,\"AssemblyProperties\":{\"$id\":\"2\",\"Name\":\"System.Private.CoreLib\",\"Version\":\"6.0.0.0\",\"FullName\":\"System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e\",\"CodeBase\":\"file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Private.CoreLib.dll\",\"EscapedCodeBase\":\"file:///C:/Program%20Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Private.CoreLib.dll\",\"VersionCompatibility\":1,\"ContentType\":0,\"CultureName\":\"\",\"Flags\":1,\"HashAlgorithm\":32772,\"KeyPair\":null,\"ProcessorArchitecture\":4}}" 
)]
	public /*static*/ class SafeFileHandle
	{
		private /*static*/ Microsoft.Win32.SafeHandles.SafeFileHandle _NOAI_l0Connection_UnderlyingTypeBaseInstance;

		public /*static*/ SafeFileHandle(Microsoft.Win32.SafeHandles.SafeFileHandle NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance;
		}

		public /*static*/ Microsoft.Win32.SafeHandles.SafeFileHandle NOAI_l0Connection_UnderlyingTypeBaseInstance
		{ get { return _NOAI_l0Connection_UnderlyingTypeBaseInstance; } }

		/// 
		public /*static*/ SafeFileHandle(
			System.IntPtr preexistingHandle,
			System.Boolean ownsHandle)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new Microsoft.Win32.SafeHandles.SafeFileHandle(
				preexistingHandle,
				ownsHandle)
		}

		/// 
		public /*static*/ SafeFileHandle(
			)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new Microsoft.Win32.SafeHandles.SafeFileHandle(
				)
		}

		/// 
		public /*static*/ System.String Path
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Path); }
		}

		/// 
		public /*static*/ System.Boolean IsAsync
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsAsync); }
		}

		/// 
		public /*static*/ System.Boolean CanSeek
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.CanSeek); }
		}

		/// 
		public /*static*/ ThreadPoolBoundHandle ThreadPoolBinding
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new ThreadPoolBoundHandle(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ThreadPoolBinding)); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ThreadPoolBinding = value
					.NOAI_l0Connection_UnderlyingTypeBaseInstance); }
		}

		public override int GetHashCode()
		{
			return _NOAI_l0Connection_UnderlyingTypeBaseInstance.GetHashCode();
		}

	}
}

