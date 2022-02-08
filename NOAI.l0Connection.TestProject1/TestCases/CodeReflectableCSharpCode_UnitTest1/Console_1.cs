using NOAI.l0Connection;
using NOAI_System__Runtime__Versioning_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System__IO_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System__Text_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System_System__Console____Version__6__0__0__0____Culture__neutral____PublicKeyToken__b03f5f7f11d50a3a_0__00__00;

namespace NOAI_System_System__Console____Version__6__0__0__0____Culture__neutral____PublicKeyToken__b03f5f7f11d50a3a_0__00__00
{
	/// <summary>Represents the standard input, output, and error streams for console applications. This class cannot be inherited.</summary>
	[System.Runtime.CompilerServices.NullableContextAttribute(1)]
	[System.Runtime.CompilerServices.NullableAttribute(0)]
	[NOAI_l0Connection_ConnGenAttribute(
TypeInfoJson:"{\"$id\":\"1\",\"ContextGuid\":\"00000000-0000-0000-0000-000000000000\",\"ContextDate\":\"0001-01-01T00:00:00\",\"Namespace\":\"System\",\"IsPublic\":true,\"IsStatic\":true,\"Name\":\"Console\",\"IsPrimitive\":false,\"IsSealed\":true,\"IsVisible\":true,\"IsValueType\":false,\"GUID\":\"34cc8e06-04c2-361d-a47d-874838ca8e3b\",\"Attributes\":1048961,\"HasElementType\":false,\"IsGenericMethodParameter\":false,\"IsGenericParameter\":false,\"IsGenericType\":false,\"IsGenericTypeDefinition\":false,\"IsGenericTypeParameter\":false,\"GenericParameterAttributes\":0,\"GenericParameterPosition\":0,\"GenericTypeArguments\":[],\"IsAbstract\":true,\"IsAnsiClass\":true,\"IsArray\":false,\"IsAutoClass\":false,\"IsAutoLayout\":true,\"IsByRef\":false,\"IsByRefLike\":false,\"IsClass\":true,\"IsCOMObject\":false,\"IsConstructedGenericType\":false,\"IsContextful\":false,\"IsEnum\":false,\"IsExplicitLayout\":false,\"IsImport\":false,\"IsInterface\":false,\"IsLayoutSequential\":false,\"IsMarshalByRef\":false,\"IsNested\":false,\"IsNestedAssembly\":false,\"IsNestedFamANDAssem\":false,\"IsNestedFamily\":false,\"IsNestedFamORAssem\":false,\"IsNestedPrivate\":false,\"IsNestedPublic\":false,\"IsNotPublic\":false,\"IsPointer\":false,\"IsSecurityCritical\":true,\"IsSecuritySafeCritical\":false,\"IsSecurityTransparent\":false,\"IsSerializable\":false,\"IsSignatureType\":false,\"IsSpecialName\":false,\"IsSZArray\":false,\"IsTypeDefinition\":true,\"IsUnicodeClass\":false,\"IsVariableBoundArray\":false,\"AssemblyName\":{\"$id\":\"2\",\"Name\":\"System.Console\",\"Version\":\"6.0.0.0\",\"FullName\":\"System.Console, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a\",\"CodeBase\":\"file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Console.dll\",\"EscapedCodeBase\":\"file:///C:/Program%20Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Console.dll\",\"VersionCompatibility\":1,\"ContentType\":0,\"CultureName\":\"\",\"Flags\":1,\"HashAlgorithm\":32772,\"KeyPair\":null,\"ProcessorArchitecture\":1}}", 
)]
	public static class Console
	{
		private static System.Console _NOAI_l0Connection_UnderlyingTypeBaseInstance = System.Console;

		/// <summary>Gets the standard input stream.</summary>
		/// <returns>A <see cref="T:System.IO.TextReader" /> that represents the standard input stream.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		[UnsupportedOSPlatformAttribute("android")]
		[UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("ios")]
		[UnsupportedOSPlatformAttribute("tvos")]
		public static TextReader In
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.In); }
		}

		/// <summary>Gets or sets the encoding the console uses to read input.</summary>
		/// <exception cref="T:System.ArgumentNullException">The property value in a set operation is <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception>
		/// <exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception>
		/// <returns>The encoding used to read console input.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		[UnsupportedOSPlatformAttribute("android")]
		[UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("ios")]
		[UnsupportedOSPlatformAttribute("tvos")]
		public static Encoding InputEncoding
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.InputEncoding); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.InputEncoding = value}; }
		}

		/// <summary>Gets or sets the encoding the console uses to write output.</summary>
		/// <exception cref="T:System.ArgumentNullException">The property value in a set operation is <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception>
		/// <exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception>
		/// <returns>The encoding used to write console output.</returns>
		public static Encoding OutputEncoding
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.OutputEncoding); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.OutputEncoding = value}; }
		}

		/// <summary>Gets a value indicating whether a key press is available in the input stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.InvalidOperationException">Standard input is redirected to a file instead of the keyboard.</exception>
		/// <returns>
		/// <see langword="true" /> if a key press is available; otherwise, <see langword="false" />.</returns>
		public static System.Boolean KeyAvailable
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.KeyAvailable); }
		}

		/// <summary>Gets the standard output stream.</summary>
		/// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard output stream.</returns>
		public static TextWriter Out
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Out); }
		}

		/// <summary>Gets the standard error output stream.</summary>
		/// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard error output stream.</returns>
		public static TextWriter Error
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Error); }
		}

		/// <summary>Gets a value that indicates whether input has been redirected from the standard input stream.</summary>
		/// <returns>
		/// <see langword="true" /> if input is redirected; otherwise, <see langword="false" />.</returns>
		public static System.Boolean IsInputRedirected
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsInputRedirected); }
		}

		/// <summary>Gets a value that indicates whether output has been redirected from the standard output stream.</summary>
		/// <returns>
		/// <see langword="true" /> if output is redirected; otherwise, <see langword="false" />.</returns>
		public static System.Boolean IsOutputRedirected
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsOutputRedirected); }
		}

		/// <summary>Gets a value that indicates whether the error output stream has been redirected from the standard error stream.</summary>
		/// <returns>
		/// <see langword="true" /> if error output is redirected; otherwise, <see langword="false" />.</returns>
		public static System.Boolean IsErrorRedirected
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsErrorRedirected); }
		}

		/// <summary>Gets or sets the height of the cursor within a character cell.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 1 or greater than 100.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
		/// <returns>The size of the cursor expressed as a percentage of the height of a character cell. The property value ranges from 1 to 100.</returns>
		public static System.Int32 CursorSize
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.CursorSize); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.CursorSize = value}; }
		}

		/// <summary>Gets a value indicating whether the NUM LOCK keyboard toggle is turned on or turned off.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">The get operation is invoked on an operating system other than Windows.</exception>
		/// <returns>
		/// <see langword="true" /> if NUM LOCK is turned on; <see langword="false" /> if NUM LOCK is turned off.</returns>
		[System.Runtime.Versioning.SupportedOSPlatformAttribute("windows")]
		[SupportedOSPlatformAttribute("windows")]
		public static System.Boolean NumberLock
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.NumberLock); }
		}

		/// <summary>Gets a value indicating whether the CAPS LOCK keyboard toggle is turned on or turned off.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">The get operation is invoked on an operating system other than Windows.</exception>
		/// <returns>
		/// <see langword="true" /> if CAPS LOCK is turned on; <see langword="false" /> if CAPS LOCK is turned off.</returns>
		[System.Runtime.Versioning.SupportedOSPlatformAttribute("windows")]
		[SupportedOSPlatformAttribute("windows")]
		public static System.Boolean CapsLock
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.CapsLock); }
		}

		/// <summary>Gets or sets the background color of the console.</summary>
		/// <exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <returns>A value that specifies the background color of the console; that is, the color that appears behind each character. The default is black.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		[UnsupportedOSPlatformAttribute("android")]
		[UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("ios")]
		[UnsupportedOSPlatformAttribute("tvos")]
		public static ConsoleColor BackgroundColor
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.BackgroundColor); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.BackgroundColor = value}; }
		}

		/// <summary>Gets or sets the foreground color of the console.</summary>
		/// <exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <returns>A <see cref="T:System.ConsoleColor" /> that specifies the foreground color of the console; that is, the color of each character that is displayed. The default is gray.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		[UnsupportedOSPlatformAttribute("android")]
		[UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("ios")]
		[UnsupportedOSPlatformAttribute("tvos")]
		public static ConsoleColor ForegroundColor
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.ForegroundColor); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.ForegroundColor = value}; }
		}

		/// <summary>Gets or sets the width of the buffer area.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.
		/// -or-
		/// The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
		/// -or-
		/// The value in a set operation is less than <see cref="P:System.Console.WindowLeft" /> + <see cref="P:System.Console.WindowWidth" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
		/// <returns>The current width, in columns, of the buffer area.</returns>
		public static System.Int32 BufferWidth
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.BufferWidth); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.BufferWidth = value}; }
		}

		/// <summary>Gets or sets the height of the buffer area.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.
		/// -or-
		/// The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
		/// -or-
		/// The value in a set operation is less than <see cref="P:System.Console.WindowTop" /> + <see cref="P:System.Console.WindowHeight" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
		/// <returns>The current height, in rows, of the buffer area.</returns>
		public static System.Int32 BufferHeight
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.BufferHeight); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.BufferHeight = value}; }
		}

		/// <summary>Gets or sets the leftmost position of the console window area relative to the screen buffer.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.
		/// -or-
		/// As a result of the assignment, <see cref="P:System.Console.WindowLeft" /> plus <see cref="P:System.Console.WindowWidth" /> would exceed <see cref="P:System.Console.BufferWidth" />.</exception>
		/// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
		/// <returns>The leftmost console window position measured in columns.</returns>
		public static System.Int32 WindowLeft
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WindowLeft); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WindowLeft = value}; }
		}

		/// <summary>Gets or sets the top position of the console window area relative to the screen buffer.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.
		/// -or-
		/// As a result of the assignment, <see cref="P:System.Console.WindowTop" /> plus <see cref="P:System.Console.WindowHeight" /> would exceed <see cref="P:System.Console.BufferHeight" />.</exception>
		/// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
		/// <returns>The uppermost console window position measured in rows.</returns>
		public static System.Int32 WindowTop
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WindowTop); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WindowTop = value}; }
		}

		/// <summary>Gets or sets the width of the console window.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is less than or equal to 0.
		/// -or-
		/// The value of the <see cref="P:System.Console.WindowHeight" /> property plus the value of the <see cref="P:System.Console.WindowTop" /> property is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
		/// -or-
		/// The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception>
		/// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
		/// <returns>The width of the console window measured in columns.</returns>
		public static System.Int32 WindowWidth
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WindowWidth); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WindowWidth = value}; }
		}

		/// <summary>Gets or sets the height of the console window area.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is less than or equal to 0.
		/// -or-
		/// The value of the <see cref="P:System.Console.WindowHeight" /> property plus the value of the <see cref="P:System.Console.WindowTop" /> property is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
		/// -or-
		/// The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception>
		/// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
		/// <returns>The height of the console window measured in rows.</returns>
		public static System.Int32 WindowHeight
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WindowHeight); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WindowHeight = value}; }
		}

		/// <summary>Gets the largest possible number of console window columns, based on the current font and screen resolution.</summary>
		/// <returns>The width of the largest possible console window measured in columns.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		[UnsupportedOSPlatformAttribute("android")]
		[UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("ios")]
		[UnsupportedOSPlatformAttribute("tvos")]
		public static System.Int32 LargestWindowWidth
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.LargestWindowWidth); }
		}

		/// <summary>Gets the largest possible number of console window rows, based on the current font and screen resolution.</summary>
		/// <returns>The height of the largest possible console window measured in rows.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		[UnsupportedOSPlatformAttribute("android")]
		[UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("ios")]
		[UnsupportedOSPlatformAttribute("tvos")]
		public static System.Int32 LargestWindowHeight
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.LargestWindowHeight); }
		}

		/// <summary>Gets or sets a value indicating whether the cursor is visible.</summary>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The get operation is invoked on an operating system other than Windows.</exception>
		/// <returns>
		/// <see langword="true" /> if the cursor is visible; otherwise, <see langword="false" />.</returns>
		public static System.Boolean CursorVisible
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.CursorVisible); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.CursorVisible = value}; }
		}

		/// <summary>Gets or sets the column position of the cursor within the buffer area.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.
		/// -or-
		/// The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferWidth" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <returns>The current position, in columns, of the cursor.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		[UnsupportedOSPlatformAttribute("android")]
		[UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("ios")]
		[UnsupportedOSPlatformAttribute("tvos")]
		public static System.Int32 CursorLeft
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.CursorLeft); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.CursorLeft = value}; }
		}

		/// <summary>Gets or sets the row position of the cursor within the buffer area.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.
		/// -or-
		/// The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferHeight" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <returns>The current position, in rows, of the cursor.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		[UnsupportedOSPlatformAttribute("android")]
		[UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("ios")]
		[UnsupportedOSPlatformAttribute("tvos")]
		public static System.Int32 CursorTop
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.CursorTop); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.CursorTop = value}; }
		}

		/// <summary>Gets or sets the title to display in the console title bar.</summary>
		/// <exception cref="T:System.InvalidOperationException">In a get operation, the retrieved title is longer than 24500 characters.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the specified title is longer than 24500 characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">In a set operation, the specified title is <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The get operation is invoked on an operating system other than Windows.</exception>
		/// <returns>The string to be displayed in the title bar of the console. The maximum length of the title string is 24500 characters.</returns>
		public static System.String Title
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Title); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Title = value}; }
		}

		/// <summary>Gets or sets a value indicating whether the combination of the <see cref="F:System.ConsoleModifiers.Control" /> modifier key and <see cref="F:System.ConsoleKey.C" /> console key (Ctrl+C) is treated as ordinary input or as an interruption that is handled by the operating system.</summary>
		/// <exception cref="T:System.IO.IOException">Unable to get or set the input mode of the console input buffer.</exception>
		/// <returns>
		/// <see langword="true" /> if Ctrl+C is treated as ordinary input; otherwise, <see langword="false" />.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		[UnsupportedOSPlatformAttribute("android")]
		[UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("ios")]
		[UnsupportedOSPlatformAttribute("tvos")]
		public static System.Boolean TreatControlCAsInput
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.TreatControlCAsInput); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter((
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.TreatControlCAsInput = value}; }
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(System.String format, Object arg0)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(format, arg0));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void WriteLine(System.String format, Object arg0, Object arg1)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(format, arg0, arg1));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void WriteLine(System.String format, Object arg0, Object arg1, Object arg2)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(format, arg0, arg1, arg2));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(System.String format, Object[] arg)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(format, arg));
		}

		/// 
		public static void Write(System.String format, Object arg0)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(format, arg0));
		}

		/// 
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void Write(System.String format, Object arg0, Object arg1)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(format, arg0, arg1));
		}

		/// 
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void Write(System.String format, Object arg0, Object arg1, Object arg2)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(format, arg0, arg1, arg2));
		}

		/// 
		public static void Write(System.String format, Object[] arg)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(format, arg));
		}

		/// 
		public static void Write(System.Boolean value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		public static void Write(System.Char value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void Write(Char[] buffer)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(buffer));
		}

		/// 
		public static void Write(Char[] buffer, System.Int32 index, System.Int32 count)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(buffer, index, count));
		}

		/// 
		public static void Write(System.Double value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		public static void Write(Decimal value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		public static void Write(System.Single value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		public static void Write(System.Int32 value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		[System.CLSCompliantAttribute(false)]
		public static void Write(System.UInt32 value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		public static void Write(System.Int64 value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		[System.CLSCompliantAttribute(false)]
		public static void Write(System.UInt64 value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void Write(Object value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// 
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void Write(System.String value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Write(value));
		}

		/// <summary>Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.</summary>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In" /> property is redirected from some stream other than the console.</exception>
		/// <returns>An object that describes the <see cref="T:System.ConsoleKey" /> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo" /> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers" /> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		public static ConsoleKeyInfo ReadKey()
		{
			return new ConsoleKeyInfo(NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadKey()));
		}

		/// <summary>Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.</summary>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In" /> property is redirected from some stream other than the console.</exception>
		/// <returns>An object that describes the <see cref="T:System.ConsoleKey" /> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo" /> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers" /> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		public static ConsoleKeyInfo ReadKey(System.Boolean intercept)
		{
			return new ConsoleKeyInfo(NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadKey(intercept)));
		}

		/// <summary>Sets the foreground and background console colors to their defaults.</summary>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		public static void ResetColor()
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.ResetColor());
		}

		/// 
		[System.Runtime.Versioning.SupportedOSPlatformAttribute("windows")]
		public static void SetBufferSize(System.Int32 width, System.Int32 height)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.SetBufferSize(width, height));
		}

		/// 
		[System.Runtime.Versioning.SupportedOSPlatformAttribute("windows")]
		public static void SetWindowPosition(System.Int32 left, System.Int32 top)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.SetWindowPosition(left, top));
		}

		/// 
		[System.Runtime.Versioning.SupportedOSPlatformAttribute("windows")]
		public static void SetWindowSize(System.Int32 width, System.Int32 height)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.SetWindowSize(width, height));
		}

		/// <summary>Gets the position of the cursor.</summary>
		/// <returns>The column and row position of the cursor.</returns>
		[System.Runtime.CompilerServices.NullableContextAttribute(0)]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		public static ValueTuple`2 GetCursorPosition()
		{
			return new ValueTuple`2(NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.GetCursorPosition()));
		}

		/// <summary>Plays the sound of a beep through the console speaker.</summary>
		/// <exception cref="T:System.Security.HostProtectionException">This method was executed on a server, such as SQL Server, that does not permit access to a user interface.</exception>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		public static void Beep()
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Beep());
		}

		/// <summary>Plays the sound of a beep through the console speaker.</summary>
		/// <exception cref="T:System.Security.HostProtectionException">This method was executed on a server, such as SQL Server, that does not permit access to a user interface.</exception>
		[System.Runtime.Versioning.SupportedOSPlatformAttribute("windows")]
		public static void Beep(System.Int32 frequency, System.Int32 duration)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Beep(frequency, duration));
		}

		/// 
		[System.Runtime.Versioning.SupportedOSPlatformAttribute("windows")]
		public static void MoveBufferArea(System.Int32 sourceLeft, System.Int32 sourceTop, System.Int32 sourceWidth, System.Int32 sourceHeight, System.Int32 targetLeft, System.Int32 targetTop)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop));
		}

		/// 
		[System.Runtime.Versioning.SupportedOSPlatformAttribute("windows")]
		public static void MoveBufferArea(System.Int32 sourceLeft, System.Int32 sourceTop, System.Int32 sourceWidth, System.Int32 sourceHeight, System.Int32 targetLeft, System.Int32 targetTop, System.Char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor));
		}

		/// <summary>Clears the console buffer and corresponding console window of display information.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		public static void Clear()
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Clear());
		}

		/// 
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		public static void SetCursorPosition(System.Int32 left, System.Int32 top)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.SetCursorPosition(left, top));
		}

		/// 
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void add_CancelKeyPress(ConsoleCancelEventHandler value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.add_CancelKeyPress(value));
		}

		/// 
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void remove_CancelKeyPress(ConsoleCancelEventHandler value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.remove_CancelKeyPress(value));
		}

		/// <summary>Acquires the standard input stream.</summary>
		/// <returns>The standard input stream.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		public static Stream OpenStandardInput()
		{
			return new Stream(NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.OpenStandardInput()));
		}

		/// <summary>Acquires the standard input stream.</summary>
		/// <returns>The standard input stream.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		public static Stream OpenStandardInput(System.Int32 bufferSize)
		{
			return new Stream(NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.OpenStandardInput(bufferSize)));
		}

		/// <summary>Acquires the standard output stream.</summary>
		/// <returns>The standard output stream.</returns>
		public static Stream OpenStandardOutput()
		{
			return new Stream(NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.OpenStandardOutput()));
		}

		/// <summary>Acquires the standard output stream.</summary>
		/// <returns>The standard output stream.</returns>
		public static Stream OpenStandardOutput(System.Int32 bufferSize)
		{
			return new Stream(NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.OpenStandardOutput(bufferSize)));
		}

		/// <summary>Acquires the standard error stream.</summary>
		/// <returns>The standard error stream.</returns>
		public static Stream OpenStandardError()
		{
			return new Stream(NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.OpenStandardError()));
		}

		/// <summary>Acquires the standard error stream.</summary>
		/// <returns>The standard error stream.</returns>
		public static Stream OpenStandardError(System.Int32 bufferSize)
		{
			return new Stream(NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.OpenStandardError(bufferSize)));
		}

		/// 
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("ios")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("tvos")]
		public static void SetIn(TextReader newIn)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.SetIn(newIn));
		}

		/// 
		public static void SetOut(TextWriter newOut)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.SetOut(newOut));
		}

		/// 
		public static void SetError(TextWriter newError)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.SetError(newError));
		}

		/// <summary>Reads the next character from the standard input stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <returns>The next character from the input stream, or negative one (-1) if there are currently no more characters to be read.</returns>
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		public static System.Int32 Read()
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.Read());
		}

		/// <summary>Reads the next line of characters from the standard input stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line of characters is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <returns>The next line of characters from the input stream, or <see langword="null" /> if no more lines are available.</returns>
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("android")]
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		public static System.String ReadLine()
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.ReadLine());
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine()
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine());
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(System.Boolean value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(System.Char value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void WriteLine(Char[] buffer)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(buffer));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(Char[] buffer, System.Int32 index, System.Int32 count)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(buffer, index, count));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(Decimal value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(System.Double value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(System.Single value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(System.Int32 value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[System.CLSCompliantAttribute(false)]
		public static void WriteLine(System.UInt32 value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		public static void WriteLine(System.Int64 value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[System.CLSCompliantAttribute(false)]
		public static void WriteLine(System.UInt64 value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void WriteLine(Object value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public static void WriteLine(System.String value)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(
				()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance.WriteLine(value));
		}

	}
}

