using NOAI.l0Connection;
using NOAI_System_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System__Threading_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System__Threading__Tasks_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System__Runtime__Versioning_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;
using NOAI_System__Runtime__CompilerServices_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00;

namespace NOAI_System__Threading__Tasks_System__Private__CoreLib____Version__6__0__0__0____Culture__neutral____PublicKeyToken__7cec85d7bea7798e_0__00__00
{
	/// 
	//[System.Runtime.CompilerServices.NullableContextAttribute(1)]
	//[System.Runtime.CompilerServices.NullableAttribute(0)]
	[System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Threading.Tasks.SystemThreadingTasks_TaskDebugView))]
	[System.Diagnostics.DebuggerDisplayAttribute("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
	[NOAI_l0Connection_ConnGenAttribute(
TypeInfoJson="{\"$id\":\"1\",\"ContextGuid\":\"00000000-0000-0000-0000-000000000000\",\"ContextDate\":\"0001-01-01T00:00:00\",\"AssemblyName\":null,\"Namespace\":\"System.Threading.Tasks\",\"IsPublic\":true,\"IsStatic\":false,\"Name\":\"Task\",\"IsPrimitive\":false,\"IsSealed\":false,\"IsVisible\":true,\"IsValueType\":false,\"GUID\":\"3837b2cd-30c6-3e7d-953b-04eb240f2aa0\",\"Attributes\":1048577,\"HasElementType\":false,\"IsGenericMethodParameter\":false,\"IsGenericParameter\":false,\"IsGenericType\":false,\"IsGenericTypeDefinition\":false,\"IsGenericTypeParameter\":false,\"GenericParameterAttributes\":0,\"GenericParameterPosition\":0,\"GenericTypeArguments\":[],\"IsAbstract\":false,\"IsAnsiClass\":true,\"IsArray\":false,\"IsAutoClass\":false,\"IsAutoLayout\":true,\"IsByRef\":false,\"IsByRefLike\":false,\"IsClass\":true,\"IsCOMObject\":false,\"IsConstructedGenericType\":false,\"IsContextful\":false,\"IsEnum\":false,\"IsExplicitLayout\":false,\"IsImport\":false,\"IsInterface\":false,\"IsLayoutSequential\":false,\"IsMarshalByRef\":false,\"IsNested\":false,\"IsNestedAssembly\":false,\"IsNestedFamANDAssem\":false,\"IsNestedFamily\":false,\"IsNestedFamORAssem\":false,\"IsNestedPrivate\":false,\"IsNestedPublic\":false,\"IsNotPublic\":false,\"IsPointer\":false,\"IsSecurityCritical\":true,\"IsSecuritySafeCritical\":false,\"IsSecurityTransparent\":false,\"IsSerializable\":false,\"IsSignatureType\":false,\"IsSpecialName\":false,\"IsSZArray\":false,\"IsTypeDefinition\":true,\"IsUnicodeClass\":false,\"IsVariableBoundArray\":false,\"AssemblyProperties\":{\"$id\":\"2\",\"Name\":\"System.Private.CoreLib\",\"Version\":\"6.0.0.0\",\"FullName\":\"System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e\",\"CodeBase\":\"file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Private.CoreLib.dll\",\"EscapedCodeBase\":\"file:///C:/Program%20Files/dotnet/shared/Microsoft.NETCore.App/6.0.1/System.Private.CoreLib.dll\",\"VersionCompatibility\":1,\"ContentType\":0,\"CultureName\":\"\",\"Flags\":1,\"HashAlgorithm\":32772,\"KeyPair\":null,\"ProcessorArchitecture\":4}}" 
)]
	public /*static*/ class Task
	 : IAsyncResult, IDisposable
	{
		private /*static*/ System.Threading.Tasks.Task _NOAI_l0Connection_UnderlyingTypeBaseInstance;

		public /*static*/ Task(System.Threading.Tasks.Task NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance;
		}

		public /*static*/ System.Threading.Tasks.Task NOAI_l0Connection_UnderlyingTypeBaseInstance
		{ get { return _NOAI_l0Connection_UnderlyingTypeBaseInstance; } }

		/// 
		public /*static*/ Task(
			Action action)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new System.Threading.Tasks.Task(
				action);
		}

		/// 
		public /*static*/ Task(
			Action action,
			CancellationToken cancellationToken)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new System.Threading.Tasks.Task(
				action,
				cancellationToken);
		}

		/// 
		public /*static*/ Task(
			Action action,
			TaskCreationOptions creationOptions)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new System.Threading.Tasks.Task(
				action,
				creationOptions);
		}

		/// 
		public /*static*/ Task(
			Action action,
			CancellationToken cancellationToken,
			TaskCreationOptions creationOptions)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new System.Threading.Tasks.Task(
				action,
				cancellationToken,
				creationOptions);
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public /*static*/ Task(
			Action<System.Object> action,
			System.Object state)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new System.Threading.Tasks.Task(
				action,
				state);
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public /*static*/ Task(
			Action<System.Object> action,
			System.Object state,
			CancellationToken cancellationToken)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new System.Threading.Tasks.Task(
				action,
				state,
				cancellationToken);
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public /*static*/ Task(
			Action<System.Object> action,
			System.Object state,
			TaskCreationOptions creationOptions)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new System.Threading.Tasks.Task(
				action,
				state,
				creationOptions);
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		public /*static*/ Task(
			Action<System.Object> action,
			System.Object state,
			CancellationToken cancellationToken,
			TaskCreationOptions creationOptions)
		{
			_NOAI_l0Connection_UnderlyingTypeBaseInstance = new System.Threading.Tasks.Task(
				action,
				state,
				cancellationToken,
				creationOptions);
		}

		/// 
		//[System.Runtime.CompilerServices.NullableAttribute(2)]
		//[NullableAttribute(2)]
		public /*static*/ Task ParentForDebugger
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new Task(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ParentForDebugger)); }
		}

		/// 
		public /*static*/ System.Int32 StateFlagsForDebugger
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.StateFlagsForDebugger); }
		}

		/// 
		public /*static*/ TaskStateFlags StateFlags
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new TaskStateFlags(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.StateFlags)); }
		}

		/// 
		public /*static*/ System.String DebuggerDisplayMethodDescription
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.DebuggerDisplayMethodDescription); }
		}

		/// 
		public /*static*/ TaskCreationOptions Options
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new TaskCreationOptions(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Options)); }
		}

		/// 
		public /*static*/ System.Boolean IsWaitNotificationEnabledOrNotRanToCompletion
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsWaitNotificationEnabledOrNotRanToCompletion); }
		}

		/// 
		public /*static*/ System.Boolean ShouldNotifyDebuggerOfWaitCompletion
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ShouldNotifyDebuggerOfWaitCompletion); }
		}

		/// 
		public /*static*/ System.Boolean IsWaitNotificationEnabled
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsWaitNotificationEnabled); }
		}

		/// 
		public /*static*/ System.Int32 Id
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Id); }
		}

		/// 
		public /*static*/ Nullable<System.Int32> CurrentId
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new Nullable<System.Int32>(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.CurrentId)); }
		}

		/// 
		//[System.Runtime.CompilerServices.NullableAttribute(2)]
		//[NullableAttribute(2)]
		public /*static*/ Task InternalCurrent
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new Task(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.InternalCurrent)); }
		}

		/// 
		//[System.Runtime.CompilerServices.NullableAttribute(2)]
		//[NullableAttribute(2)]
		public /*static*/ AggregateException Exception
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new AggregateException(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Exception)); }
		}

		/// 
		public /*static*/ TaskStatus Status
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new TaskStatus(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Status)); }
		}

		/// 
		public /*static*/ System.Boolean IsCanceled
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsCanceled); }
		}

		/// 
		public /*static*/ System.Boolean IsCancellationRequested
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsCancellationRequested); }
		}

		/// 
		public /*static*/ CancellationToken CancellationToken
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new CancellationToken(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.CancellationToken)); }
		}

		/// 
		public /*static*/ System.Boolean IsCancellationAcknowledged
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsCancellationAcknowledged); }
		}

		/// 
		public /*static*/ System.Boolean IsCompleted
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsCompleted); }
		}

		/// 
		public /*static*/ System.Boolean IsCompletedSuccessfully
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsCompletedSuccessfully); }
		}

		/// 
		public /*static*/ TaskCreationOptions CreationOptions
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new TaskCreationOptions(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.CreationOptions)); }
		}

		/// 
		public /*static*/ WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new WaitHandle(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.System.IAsyncResult.AsyncWaitHandle)); }
		}

		/// 
		//[System.Runtime.CompilerServices.NullableAttribute(2)]
		//[NullableAttribute(2)]
		public /*static*/ System.Object AsyncState
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.AsyncState); }
		}

		/// 
		public /*static*/ System.Boolean System.IAsyncResult.CompletedSynchronously
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.System.IAsyncResult.CompletedSynchronously); }
		}

		/// 
		//[System.Runtime.CompilerServices.NullableAttribute(2)]
		//[NullableAttribute(2)]
		public /*static*/ TaskScheduler ExecutingTaskScheduler
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new TaskScheduler(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ExecutingTaskScheduler)); }
		}

		/// 
		public /*static*/ TaskFactory Factory
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new TaskFactory(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Factory)); }
		}

		/// 
		public /*static*/ Task CompletedTask
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new Task(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.CompletedTask)); }
		}

		/// 
		public /*static*/ ManualResetEventSlim CompletedEvent
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new ManualResetEventSlim(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.CompletedEvent)); }
		}

		/// 
		public /*static*/ System.Boolean ExceptionRecorded
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ExceptionRecorded); }
		}

		/// 
		public /*static*/ System.Boolean IsFaulted
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsFaulted); }
		}

		/// 
		//[System.Runtime.CompilerServices.NullableAttribute(2)]
		//[NullableAttribute(2)]
		public /*static*/ ExecutionContext CapturedContext
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>new ExecutionContext(
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.CapturedContext)); }
			set { NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.CapturedContext = value
					.NOAI_l0Connection_UnderlyingTypeBaseInstance); }
		}

		/// 
		public /*static*/ System.Boolean IsExceptionObservedByParent
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsExceptionObservedByParent); }
		}

		/// 
		public /*static*/ System.Boolean IsDelegateInvoked
		{
			get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.IsDelegateInvoked); }
		}

		/// 
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("browser")]
		public static /*async*/ System.Boolean WaitAll(
			Task[] tasks,
			System.Int32 millisecondsTimeout)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAll(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					millisecondsTimeout));
		}

		/// 
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("browser")]
		public static /*async*/ void WaitAll(
			Task[] tasks,
			CancellationToken cancellationToken)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAll(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("browser")]
		public static /*async*/ System.Boolean WaitAll(
			Task[] tasks,
			System.Int32 millisecondsTimeout,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAll(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					millisecondsTimeout,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public static /*async*/ System.Int32 WaitAny(
			Task[] tasks)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAny(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public static /*async*/ System.Int32 WaitAny(
			Task[] tasks,
			TimeSpan timeout)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAny(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					timeout.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public static /*async*/ System.Int32 WaitAny(
			Task[] tasks,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAny(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public static /*async*/ System.Int32 WaitAny(
			Task[] tasks,
			System.Int32 millisecondsTimeout)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAny(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					millisecondsTimeout));
		}

		/// 
		public static /*async*/ System.Int32 WaitAny(
			Task[] tasks,
			System.Int32 millisecondsTimeout,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAny(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					millisecondsTimeout,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public static /*async*/ System.Task<System.TResult> FromResult(
			System.TResult result)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.FromResult(
					result));
		}

		/// 
		public static /*async*/ Task FromException(
			Exception exception)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.FromException(
					exception.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ System.Task<System.TResult> FromException(
			Exception exception)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.FromException(
					exception.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public static /*async*/ Task FromCanceled(
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.FromCanceled(
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ System.Task<System.TResult> FromCanceled(
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.FromCanceled(
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public static /*async*/ Task Run(
			Action action)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Run(
					action.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ Task Run(
			Action action,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Run(
					action.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ System.Task<System.TResult> Run(
			System.Func<System.TResult> function)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Run(
					function));
		}

		/// 
		public static /*async*/ System.Task<System.TResult> Run(
			System.Func<System.TResult> function,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Run(
					function,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public static /*async*/ Task Run(
			Func<Task> function)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Run(
					function.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ Task Run(
			Func<Task> function,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Run(
					function.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ System.Task<System.TResult> Run(
			System.Func<System.Task<System.TResult>> function)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Run(
					function));
		}

		/// 
		public static /*async*/ System.Task<System.TResult> Run(
			System.Func<System.Task<System.TResult>> function,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Run(
					function,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public static /*async*/ Task Delay(
			TimeSpan delay)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Delay(
					delay.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ Task Delay(
			TimeSpan delay,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Delay(
					delay.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ Task Delay(
			System.Int32 millisecondsDelay)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Delay(
					millisecondsDelay)));
		}

		/// 
		public static /*async*/ Task Delay(
			System.Int32 millisecondsDelay,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Delay(
					millisecondsDelay,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ Task WhenAll(
			IEnumerable<Task> tasks)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAll(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ Task WhenAll(
			Task[] tasks)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAll(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ System.Task<System.TResult[]> WhenAll(
			System.IEnumerable<System.Task<System.TResult>> tasks)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAll(
					tasks));
		}

		/// 
		public static /*async*/ System.Task<System.TResult[]> WhenAll(
			System.Task`1[] tasks)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAll(
					tasks));
		}

		/// 
		public static /*async*/ Task<Task> WhenAny(
			Task[] tasks)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task<Task>(_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAny(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ Task<Task> WhenAny(
			Task task1,
			Task task2)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task<Task>(_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAny(
					task1.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					task2.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ Task<Task> WhenAny(
			IEnumerable<Task> tasks)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task<Task>(_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAny(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public static /*async*/ System.Task<System.Task<System.TResult>> WhenAny(
			System.Task`1[] tasks)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAny(
					tasks));
		}

		/// 
		public static /*async*/ System.Task<System.Task<System.TResult>> WhenAny(
			System.Task<System.TResult> task1,
			System.Task<System.TResult> task2)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAny(
					task1,
					task2));
		}

		/// 
		public static /*async*/ System.Task<System.Task<System.TResult>> WhenAny(
			System.IEnumerable<System.Task<System.TResult>> tasks)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WhenAny(
					tasks));
		}

		/// 
		public /*static*/ /*async*/ TaskAwaiter GetAwaiter(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new TaskAwaiter(_NOAI_l0Connection_UnderlyingTypeBaseInstance.GetAwaiter(
					)));
		}

		/// 
		public /*static*/ /*async*/ ConfiguredTaskAwaitable ConfigureAwait(
			System.Boolean continueOnCapturedContext)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new ConfiguredTaskAwaitable(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ConfigureAwait(
					continueOnCapturedContext)));
		}

		/// 
		public static /*async*/ YieldAwaitable Yield(
			)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new YieldAwaitable(_NOAI_l0Connection_UnderlyingTypeBaseInstance.Yield(
					)));
		}

		/// 
		public /*static*/ /*async*/ void Wait(
			)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Wait(
					));
		}

		/// 
		public /*static*/ /*async*/ System.Boolean Wait(
			TimeSpan timeout)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Wait(
					timeout.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ void Wait(
			CancellationToken cancellationToken)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Wait(
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ System.Boolean Wait(
			System.Int32 millisecondsTimeout)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Wait(
					millisecondsTimeout));
		}

		/// 
		public /*static*/ /*async*/ System.Boolean Wait(
			System.Int32 millisecondsTimeout,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Wait(
					millisecondsTimeout,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ Task WaitAsync(
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAsync(
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task WaitAsync(
			TimeSpan timeout)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAsync(
					timeout.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task WaitAsync(
			TimeSpan timeout,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAsync(
					timeout.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task> continuationAction)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task> continuationAction,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task> continuationAction,
			TaskScheduler scheduler)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task> continuationAction,
			TaskContinuationOptions continuationOptions)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					continuationOptions.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task> continuationAction,
			CancellationToken cancellationToken,
			TaskContinuationOptions continuationOptions,
			TaskScheduler scheduler)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					continuationOptions.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task, System.Object> continuationAction,
			System.Object state)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					state)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task, System.Object> continuationAction,
			System.Object state,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					state,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task, System.Object> continuationAction,
			System.Object state,
			TaskScheduler scheduler)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					state,
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task, System.Object> continuationAction,
			System.Object state,
			TaskContinuationOptions continuationOptions)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					state,
					continuationOptions.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ Task ContinueWith(
			Action<Task, System.Object> continuationAction,
			System.Object state,
			CancellationToken cancellationToken,
			TaskContinuationOptions continuationOptions,
			TaskScheduler scheduler)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				new Task(_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationAction.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					state,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					continuationOptions.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance)));
		}

		/// 
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.TResult> continuationFunction)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction));
		}

		/// 
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.TResult> continuationFunction,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.TResult> continuationFunction,
			TaskScheduler scheduler)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction,
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.TResult> continuationFunction,
			TaskContinuationOptions continuationOptions)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction,
					continuationOptions.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.TResult> continuationFunction,
			CancellationToken cancellationToken,
			TaskContinuationOptions continuationOptions,
			TaskScheduler scheduler)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					continuationOptions.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		//[NullableContextAttribute(2)]
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.Object, System.TResult> continuationFunction,
			System.Object state)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction,
					state));
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		//[NullableContextAttribute(2)]
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.Object, System.TResult> continuationFunction,
			System.Object state,
			CancellationToken cancellationToken)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction,
					state,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.Object, System.TResult> continuationFunction,
			System.Object state,
			TaskScheduler scheduler)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction,
					state,
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		//[System.Runtime.CompilerServices.NullableContextAttribute(2)]
		//[NullableContextAttribute(2)]
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.Object, System.TResult> continuationFunction,
			System.Object state,
			TaskContinuationOptions continuationOptions)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction,
					state,
					continuationOptions.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ System.Task<System.TResult> ContinueWith(
			System.Func<Task, System.Object, System.TResult> continuationFunction,
			System.Object state,
			CancellationToken cancellationToken,
			TaskContinuationOptions continuationOptions,
			TaskScheduler scheduler)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.ContinueWith(
					continuationFunction,
					state,
					cancellationToken.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					continuationOptions.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("browser")]
		public static /*async*/ void WaitAll(
			Task[] tasks)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAll(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		[System.Runtime.Versioning.UnsupportedOSPlatformAttribute("browser")]
		[UnsupportedOSPlatformAttribute("browser")]
		public static /*async*/ System.Boolean WaitAll(
			Task[] tasks,
			TimeSpan timeout)
		{
			return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.WaitAll(
					tasks.NOAI_l0Connection_UnderlyingTypeBaseInstance,
					timeout.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ void Start(
			)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Start(
					));
		}

		/// 
		public /*static*/ /*async*/ void Start(
			TaskScheduler scheduler)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Start(
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ void RunSynchronously(
			)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.RunSynchronously(
					));
		}

		/// 
		public /*static*/ /*async*/ void RunSynchronously(
			TaskScheduler scheduler)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.RunSynchronously(
					scheduler.NOAI_l0Connection_UnderlyingTypeBaseInstance));
		}

		/// 
		public /*static*/ /*async*/ void Dispose(
			)
		{
			NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>
				_NOAI_l0Connection_UnderlyingTypeBaseInstance.Dispose(
					));
		}

		public override int GetHashCode()
		{
			return _NOAI_l0Connection_UnderlyingTypeBaseInstance.GetHashCode();
		}

	}
}

