using System;
using Darwin;
using Foundation;
using ObjCRuntime;
using ObjectiveC;

namespace SampleSwiftLibrary
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern _RuneLocale _DefaultRuneLocale;
		[Field ("_DefaultRuneLocale", "__Internal")]
		_RuneLocale _DefaultRuneLocale { get; }

		// extern _RuneLocale * _CurrentRuneLocale;
		[Field ("_CurrentRuneLocale", "__Internal")]
		unsafe _RuneLocale* _CurrentRuneLocale { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const fenv_t _FE_DFL_ENV;
		[Field ("_FE_DFL_ENV", "__Internal")]
		fenv_t _FE_DFL_ENV { get; }

		// extern const fenv_t _FE_DFL_DISABLE_DENORMS_ENV;
		[Field ("_FE_DFL_DISABLE_DENORMS_ENV", "__Internal")]
		fenv_t _FE_DFL_DISABLE_DENORMS_ENV { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int signgam;
		[Field ("signgam", "__Internal")]
		int signgam { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const char *const [32] sys_signame;
		[Field ("sys_signame", "__Internal")]
		unsafe sbyte*[] sys_signame { get; }

		// extern const char *const [32] sys_siglist;
		[Field ("sys_siglist", "__Internal")]
		unsafe sbyte*[] sys_siglist { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern FILE * __stdinp;
		[Field ("__stdinp", "__Internal")]
		unsafe FILE* __stdinp { get; }

		// extern FILE * __stdoutp;
		[Field ("__stdoutp", "__Internal")]
		unsafe FILE* __stdoutp { get; }

		// extern FILE * __stderrp;
		[Field ("__stderrp", "__Internal")]
		unsafe FILE* __stderrp { get; }

		// extern const int sys_nerr;
		[Field ("sys_nerr", "__Internal")]
		int sys_nerr { get; }

		// extern const char *const [] sys_errlist;
		[Field ("sys_errlist", "__Internal")]
		unsafe sbyte*[] sys_errlist { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int __mb_cur_max;
		[Field ("__mb_cur_max", "__Internal")]
		int __mb_cur_max { get; }

		// extern char * suboptarg;
		[Field ("suboptarg", "__Internal")]
		unsafe sbyte* suboptarg { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char *[] tzname;
		[Field ("tzname", "__Internal")]
		unsafe sbyte*[] tzname { get; }

		// extern int getdate_err;
		[Field ("getdate_err", "__Internal")]
		int getdate_err { get; }

		// extern long timezone asm("_timezone");
		[Field ("timezone", "__Internal")]
		nint timezone { get; }

		// extern int daylight;
		[Field ("daylight", "__Internal")]
		int daylight { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const locale_t _c_locale;
		[Field ("_c_locale", "__Internal")]
		unsafe locale_t* _c_locale { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const struct in6_addr in6addr_any;
		[Field ("in6addr_any", "__Internal")]
		in6_addr in6addr_any { get; }

		// extern const struct in6_addr in6addr_loopback;
		[Field ("in6addr_loopback", "__Internal")]
		in6_addr in6addr_loopback { get; }

		// extern const struct in6_addr in6addr_nodelocal_allnodes;
		[Field ("in6addr_nodelocal_allnodes", "__Internal")]
		in6_addr in6addr_nodelocal_allnodes { get; }

		// extern const struct in6_addr in6addr_linklocal_allnodes;
		[Field ("in6addr_linklocal_allnodes", "__Internal")]
		in6_addr in6addr_linklocal_allnodes { get; }

		// extern const struct in6_addr in6addr_linklocal_allrouters;
		[Field ("in6addr_linklocal_allrouters", "__Internal")]
		in6_addr in6addr_linklocal_allrouters { get; }

		// extern const struct in6_addr in6addr_linklocal_allv2routers;
		[Field ("in6addr_linklocal_allv2routers", "__Internal")]
		in6_addr in6addr_linklocal_allv2routers { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int _libiconv_version;
		[Field ("_libiconv_version", "__Internal")]
		int _libiconv_version { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int h_errno;
		[Field ("h_errno", "__Internal")]
		int h_errno { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern security_token_t KERNEL_SECURITY_TOKEN;
		[Field ("KERNEL_SECURITY_TOKEN", "__Internal")]
		security_token_t KERNEL_SECURITY_TOKEN { get; }

		// extern audit_token_t KERNEL_AUDIT_TOKEN;
		[Field ("KERNEL_AUDIT_TOKEN", "__Internal")]
		audit_token_t KERNEL_AUDIT_TOKEN { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char * optarg;
		[Field ("optarg", "__Internal")]
		unsafe sbyte* optarg { get; }

		// extern int optind;
		[Field ("optind", "__Internal")]
		int optind { get; }

		// extern int opterr;
		[Field ("opterr", "__Internal")]
		int opterr { get; }

		// extern int optopt;
		[Field ("optopt", "__Internal")]
		int optopt { get; }

		// extern char * suboptarg;
		[Field ("suboptarg", "__Internal")]
		unsafe sbyte* suboptarg { get; }

		// extern int optreset;
		[Field ("optreset", "__Internal")]
		int optreset { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char * optarg;
		[Field ("optarg", "__Internal")]
		unsafe sbyte* optarg { get; }

		// extern int optind;
		[Field ("optind", "__Internal")]
		int optind { get; }

		// extern int opterr;
		[Field ("opterr", "__Internal")]
		int opterr { get; }

		// extern int optopt;
		[Field ("optopt", "__Internal")]
		int optopt { get; }

		// extern int optreset;
		[Field ("optreset", "__Internal")]
		int optreset { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern vm_size_t vm_page_size;
		[Field ("vm_page_size", "__Internal")]
		UIntPtr vm_page_size { get; }

		// extern vm_size_t vm_page_mask;
		[Field ("vm_page_mask", "__Internal")]
		UIntPtr vm_page_mask { get; }

		// extern int vm_page_shift;
		[Field ("vm_page_shift", "__Internal")]
		int vm_page_shift { get; }

		// extern vm_size_t vm_kernel_page_size __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("vm_kernel_page_size", "__Internal")]
		UIntPtr vm_kernel_page_size { get; }

		// extern vm_size_t vm_kernel_page_mask __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("vm_kernel_page_mask", "__Internal")]
		UIntPtr vm_kernel_page_mask { get; }

		// extern int vm_kernel_page_shift __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("vm_kernel_page_shift", "__Internal")]
		int vm_kernel_page_shift { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NDR_record_t NDR_record;
		[Field ("NDR_record", "__Internal")]
		NDR_record_t NDR_record { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern mach_port_t mach_task_self_;
		[Field ("mach_task_self_", "__Internal")]
		uint mach_task_self_ { get; }

		// extern mach_port_t bootstrap_port;
		[Field ("bootstrap_port", "__Internal")]
		uint bootstrap_port { get; }

		// extern int (*)(const char *, va_list) vprintf_stderr_func;
		[Field ("vprintf_stderr_func", "__Internal")]
		unsafe Func<sbyte*, sbyte*, int>* vprintf_stderr_func { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern struct port_obj_tentry * port_obj_table;
		[Field ("port_obj_table", "__Internal")]
		unsafe port_obj_tentry* port_obj_table { get; }

		// extern int port_obj_table_size;
		[Field ("port_obj_table_size", "__Internal")]
		int port_obj_table_size { get; }
	}

	// typedef void (^os_block_t)();
	delegate void os_block_t ();

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern void *[32] _NSConcreteGlobalBlock __attribute__((availability(ios, introduced=3.2)));
		[iOS (3, 2)]
		[Field ("_NSConcreteGlobalBlock", "__Internal")]
		unsafe void*[] _NSConcreteGlobalBlock { get; }

		// extern void *[32] _NSConcreteStackBlock __attribute__((availability(ios, introduced=3.2)));
		[iOS (3, 2)]
		[Field ("_NSConcreteStackBlock", "__Internal")]
		unsafe void*[] _NSConcreteStackBlock { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern struct loadavg averunnable;
		[Field ("averunnable", "__Internal")]
		loadavg averunnable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
	}

	// @protocol NSObject
	[Protocol, Model]
	interface NSObject
	{
		// @required -(BOOL)isEqual:(id)object;
		[Abstract]
		[Export ("isEqual:")]
		bool IsEqual (NSObject @object);

		// @required @property (readonly) NSUInteger hash;
		[Abstract]
		[Export ("hash")]
		nuint Hash { get; }

		// @required @property (readonly) Class superclass;
		[Abstract]
		[Export ("superclass")]
		Class Superclass { get; }

		// @required -(Class)class;
		[Abstract]
		[Export ("class")]
		[Verify (MethodToProperty)]
		Class Class { get; }

		// @required -(instancetype)self;
		[Abstract]
		[Export ("self")]
		NSObject Self ();

		// @required -(id)performSelector:(SEL)aSelector;
		[Abstract]
		[Export ("performSelector:")]
		NSObject PerformSelector (Selector aSelector);

		// @required -(id)performSelector:(SEL)aSelector withObject:(id)object;
		[Abstract]
		[Export ("performSelector:withObject:")]
		NSObject PerformSelector (Selector aSelector, NSObject @object);

		// @required -(id)performSelector:(SEL)aSelector withObject:(id)object1 withObject:(id)object2;
		[Abstract]
		[Export ("performSelector:withObject:withObject:")]
		NSObject PerformSelector (Selector aSelector, NSObject object1, NSObject object2);

		// @required -(BOOL)isProxy;
		[Abstract]
		[Export ("isProxy")]
		[Verify (MethodToProperty)]
		bool IsProxy { get; }

		// @required -(BOOL)isKindOfClass:(Class)aClass;
		[Abstract]
		[Export ("isKindOfClass:")]
		bool IsKindOfClass (Class aClass);

		// @required -(BOOL)isMemberOfClass:(Class)aClass;
		[Abstract]
		[Export ("isMemberOfClass:")]
		bool IsMemberOfClass (Class aClass);

		// @required -(BOOL)conformsToProtocol:(Protocol *)aProtocol;
		[Abstract]
		[Export ("conformsToProtocol:")]
		bool ConformsToProtocol (Protocol aProtocol);

		// @required -(BOOL)respondsToSelector:(SEL)aSelector;
		[Abstract]
		[Export ("respondsToSelector:")]
		bool RespondsToSelector (Selector aSelector);

		// @required -(instancetype)retain;
		[Abstract]
		[Export ("retain")]
		NSObject Retain ();

		// @required -(void)release;
		[Abstract]
		[Export ("release")]
		void Release ();

		// @required -(instancetype)autorelease;
		[Abstract]
		[Export ("autorelease")]
		NSObject Autorelease ();

		// @required -(NSUInteger)retainCount;
		[Abstract]
		[Export ("retainCount")]
		[Verify (MethodToProperty)]
		nuint RetainCount { get; }

		// @required -(struct _NSZone *)zone;
		[Abstract]
		[Export ("zone")]
		[Verify (MethodToProperty)]
		unsafe _NSZone* Zone { get; }

		// @required @property (readonly, copy) NSString * description;
		[Abstract]
		[Export ("description")]
		string Description { get; }

		// @optional @property (readonly, copy) NSString * debugDescription;
		[Export ("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface NSObject <NSObject>
	[Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
	[BaseType (typeof(NSObject))]
	interface NSObject
	{
		// +(void)load;
		[Static]
		[Export ("load")]
		void Load ();

		// +(void)initialize;
		[Static]
		[Export ("initialize")]
		void Initialize ();

		// +(instancetype)new;
		[Static]
		[Export ("new")]
		NSObject New ();

		// +(instancetype)allocWithZone:(struct _NSZone *)zone;
		[Static]
		[Export ("allocWithZone:")]
		unsafe NSObject AllocWithZone (_NSZone* zone);

		// +(instancetype)alloc;
		[Static]
		[Export ("alloc")]
		NSObject Alloc ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(void)finalize __attribute__((deprecated("Objective-C garbage collection is no longer supported")));
		[Export ("finalize")]
		void Finalize ();

		// -(id)copy;
		[Export ("copy")]
		[Verify (MethodToProperty)]
		NSObject Copy { get; }

		// -(id)mutableCopy;
		[Export ("mutableCopy")]
		[Verify (MethodToProperty)]
		NSObject MutableCopy { get; }

		// +(id)copyWithZone:(struct _NSZone *)zone;
		[Static]
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (_NSZone* zone);

		// +(id)mutableCopyWithZone:(struct _NSZone *)zone;
		[Static]
		[Export ("mutableCopyWithZone:")]
		unsafe NSObject MutableCopyWithZone (_NSZone* zone);

		// +(BOOL)instancesRespondToSelector:(SEL)aSelector;
		[Static]
		[Export ("instancesRespondToSelector:")]
		bool InstancesRespondToSelector (Selector aSelector);

		// +(BOOL)conformsToProtocol:(Protocol *)protocol;
		[Static]
		[Export ("conformsToProtocol:")]
		bool ConformsToProtocol (Protocol protocol);

		// -(IMP)methodForSelector:(SEL)aSelector;
		[Export ("methodForSelector:")]
		unsafe IMP* MethodForSelector (Selector aSelector);

		// +(IMP)instanceMethodForSelector:(SEL)aSelector;
		[Static]
		[Export ("instanceMethodForSelector:")]
		unsafe IMP* InstanceMethodForSelector (Selector aSelector);

		// -(void)doesNotRecognizeSelector:(SEL)aSelector;
		[Export ("doesNotRecognizeSelector:")]
		void DoesNotRecognizeSelector (Selector aSelector);

		// -(id)forwardingTargetForSelector:(SEL)aSelector __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
		[Watch (1,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[Export ("forwardingTargetForSelector:")]
		NSObject ForwardingTargetForSelector (Selector aSelector);

		// -(void)forwardInvocation:(NSInvocation *)anInvocation;
		[Export ("forwardInvocation:")]
		void ForwardInvocation (NSInvocation anInvocation);

		// -(NSMethodSignature *)methodSignatureForSelector:(SEL)aSelector;
		[Export ("methodSignatureForSelector:")]
		NSMethodSignature MethodSignatureForSelector (Selector aSelector);

		// +(NSMethodSignature *)instanceMethodSignatureForSelector:(SEL)aSelector;
		[Static]
		[Export ("instanceMethodSignatureForSelector:")]
		NSMethodSignature InstanceMethodSignatureForSelector (Selector aSelector);

		// +(BOOL)isSubclassOfClass:(Class)aClass;
		[Static]
		[Export ("isSubclassOfClass:")]
		bool IsSubclassOfClass (Class aClass);

		// +(BOOL)resolveClassMethod:(SEL)sel __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
		[Watch (1,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[Static]
		[Export ("resolveClassMethod:")]
		bool ResolveClassMethod (Selector sel);

		// +(BOOL)resolveInstanceMethod:(SEL)sel __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
		[Watch (1,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[Static]
		[Export ("resolveInstanceMethod:")]
		bool ResolveInstanceMethod (Selector sel);

		// +(NSUInteger)hash;
		[Static]
		[Export ("hash")]
		[Verify (MethodToProperty)]
		nuint Hash { get; }

		// +(Class)superclass;
		[Static]
		[Export ("superclass")]
		[Verify (MethodToProperty)]
		Class Superclass { get; }

		// +(Class)class;
		[Static]
		[Export ("class")]
		[Verify (MethodToProperty)]
		Class Class { get; }

		// +(NSString *)description;
		[Static]
		[Export ("description")]
		[Verify (MethodToProperty)]
		string Description { get; }

		// +(NSString *)debugDescription;
		[Static]
		[Export ("debugDescription")]
		[Verify (MethodToProperty)]
		string DebugDescription { get; }
	}

	// @interface SampleClass : NSObject
	[BaseType (typeof(NSObject))]
	interface SampleClass
	{
		// -(NSString * _Nonnull)getValue __attribute__((warn_unused_result));
		[Export ("getValue")]
		[Verify (MethodToProperty)]
		string Value { get; }
	}
}
