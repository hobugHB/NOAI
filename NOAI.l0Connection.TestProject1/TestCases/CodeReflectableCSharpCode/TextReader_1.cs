using NOAI.l0Connection;
using NOAI_System__Runtime__CompilerServices_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System__Threading_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System__IO_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;

namespace NOAI_System__IO_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00
{
	/// 
	//[System.Runtime.CompilerServices.NullableContextAttribute(1)]
	//[System.Runtime.CompilerServices.NullableAttribute(0)]
	[NOAI_l0Connection_ConnGenAttribute(
TypeInfoJson="{\"$id\":\"1\",\"ContextGuid\":\"00000000-0000-0000-0000-000000000000\",\"ContextDate\":\"0001-01-01T00:00:00\",\"AssemblyName\":null,\"Namespace\":\"System.IO\",\"IsPublic\":true,\"IsStatic\":false,\"Name\":\"TextReader\",\"IsPrimitive\":false,\"IsSealed\":false,\"IsVisible\":true,\"IsValueType\":false,\"GUID\":\"a1f97618-a98f-3c7a-beed-f9fe9aefb12b\",\"Attributes\":1048705,\"HasElementType\":false,\"IsGenericMethodParameter\":false,\"IsGenericParameter\":false,\"IsGenericType\":false,\"IsGenericTypeDefinition\":false,\"IsGenericTypeParameter\":false,\"GenericParameterAttributes\":0,\"GenericParameterPosition\":0,\"GenericTypeArguments\":[],\"IsAbstract\":true,\"IsAnsiClass\":true,\"IsArray\":false,\"IsAutoClass\":false,\"IsAutoLayout\":true,\"IsByRef\":false,\"IsByRefLike\":false,\"IsClass\":true,\"IsCOMObject\":false,\"IsConstructedGenericType\":false,\"IsContextful\":false,\"IsEnum\":false,\"IsExplicitLayout\":false,\"IsImport\":false,\"IsInterface\":false,\"IsLayoutSequential\":false,\"IsMarshalByRef\":false,\"IsNested\":false,\"IsNestedAssembly\":false,\"IsNestedFamANDAssem\":false,\"IsNestedFamily\":false,\"IsNestedFamORAssem\":false,\"IsNestedPrivate\":false,\"IsNestedPublic\":false,\"IsNotPublic\":false,\"IsPointer\":false,\"IsSecurityCritical\":true,\"IsSecuritySafeCritical\":false,\"IsSecurityTransparent\":false,\"IsSerializable\":false,\"IsSignatureType\":false,\"IsSpecialName\":false,\"IsSZArray\":false,\"IsTypeDefinition\":true,\"IsUnicodeClass\":false,\"IsVariableBoundArray\":false,\"AssemblyProperties\":{\"$id\":\"2\",\"Name\":\"System.Private.CoreLib\",\"Version\":\"6.0.0.0\",\"FullName\":\"System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e\",\"CodeBase\":\"file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Private.CoreLib.dll\",\"EscapedCodeBase\":\"file:///C:/Program%20Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Private.CoreLib.dll\",\"VersionCompatibility\":1,\"ContentType\":0,\"CultureName\":\"\",\"Flags\":1,\"HashAlgorithm\":32772,\"KeyPair\":null,\"ProcessorArchitecture\":4}}" 
)]
	public /*static*/ class TextReader
	{
		private /*static*/ System.IO.TextReader _NOAI_l0Connection_UnderlyingTypeBaseInstance;

		public /*static*/ TextReader(System.IO.TextReader NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance;
		}

		public /*static*/ System.IO.TextReader NOAI_l0Connection_UnderlyingTypeBaseInstance
		{ get { return _NOAI_l0Connection_UnderlyingTypeBaseInstance; } }

		/// 
		public /*static*/ /*async*/ void Close(
			)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Close(
					));
		}

		/// 
		public /*static*/ /*async*/ void Dispose(
			)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Dispose(
					));
		}

		/// 
		public /*static*/ /*async*/ System.Int32 Peek(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Peek(
					));
		}

		/// 
		public /*static*/ /*async*/ System.Int32 Read(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Read(
					));
		}

		/// 
		public /*static*/ /*async*/ System.Int32 Read(
			Char[] buffer,
			System.Int32 index,
			System.Int32 count)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Read(
					buffer.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					index,
					count));
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(0)]
		//[NullableContextAttribute(0)]
		public /*static*/ /*async*/ System.Int32 Read(
			Span<System.Char> buffer)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Read(
					buffer.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ System.String ReadToEnd(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadToEnd(
					));
		}

		/// 
		public /*static*/ /*async*/ System.Int32 ReadBlock(
			Char[] buffer,
			System.Int32 index,
			System.Int32 count)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadBlock(
					buffer.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					index,
					count));
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(0)]
		//[NullableContextAttribute(0)]
		public /*static*/ /*async*/ System.Int32 ReadBlock(
			Span<System.Char> buffer)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadBlock(
					buffer.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		//[NullableContextAttribute(2)]
		public /*static*/ /*async*/ System.String ReadLine(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadLine(
					));
		}

		/// 
		public /*static*/ /*async*/ Task<System.String> ReadLineAsync(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task<System.String>(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadLineAsync(
					)));
		}

		/// 
		//[System.Runtime.CompilerServices.AsyncStateMachineAttribute(null)]
		//[AsyncStateMachineAttribute(null)]
		public /*static*/ async Task<System.String> ReadToEndAsync(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task<System.String>(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadToEndAsync(
					)));
		}

		/// 
		public /*static*/ /*async*/ Task<System.Int32> ReadAsync(
			Char[] buffer,
			System.Int32 index,
			System.Int32 count)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task<System.Int32>(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadAsync(
					buffer.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					index,
					count)));
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(0)]
		//[NullableContextAttribute(0)]
		public /*static*/ /*async*/ ValueTask<System.Int32> ReadAsync(
			Memory<System.Char> buffer,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new ValueTask<System.Int32>(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadAsync(
					buffer.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task<System.Int32> ReadBlockAsync(
			Char[] buffer,
			System.Int32 index,
			System.Int32 count)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task<System.Int32>(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadBlockAsync(
					buffer.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					index,
					count)));
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(0)]
		//[NullableContextAttribute(0)]
		public /*static*/ /*async*/ ValueTask<System.Int32> ReadBlockAsync(
			Memory<System.Char> buffer,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new ValueTask<System.Int32>(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadBlockAsync(
					buffer.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ TextReader Synchronized(
			TextReader reader)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new TextReader(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Synchronized(
					reader.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		public override int GetHashCode()
		{
			return _NOAI_l0Connection_UnderlyingTypeBaseInstance.GetHashCode();
		}

	}
}

