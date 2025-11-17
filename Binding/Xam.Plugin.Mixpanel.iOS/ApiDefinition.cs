using System;
using Foundation;
//using Mixpanel;
using ObjCRuntime;

namespace Xam.Plugin.Mixpanel.iOS
{
	// @interface MixpanelPeople : NSObject
	[BaseType (typeof(NSObject))]
	interface MixpanelPeople
	{
		// @property (atomic) BOOL ignoreTime;
		[Export ("ignoreTime")]
		bool IgnoreTime { get; set; }

		// -(void)set:(NSDictionary * _Nonnull)properties;
		[Export ("set:")]
		void Set (NSDictionary properties);

		// -(void)set:(NSString * _Nonnull)property to:(id _Nonnull)object;
		[Export ("set:to:")]
		void Set (string property, NSObject @object);

		// -(void)setOnce:(NSDictionary * _Nonnull)properties;
		[Export ("setOnce:")]
		void SetOnce (NSDictionary properties);

		// -(void)unset:(NSArray * _Nonnull)properties;
		[Export ("unset:")]
		//[Verify (StronglyTypedNSArray)]
		void Unset (NSObject[] properties);

		// -(void)increment:(NSDictionary * _Nonnull)properties;
		[Export ("increment:")]
		void Increment (NSDictionary properties);

		// -(void)increment:(NSString * _Nonnull)property by:(NSNumber * _Nonnull)amount;
		[Export ("increment:by:")]
		void Increment (string property, NSNumber amount);

		// -(void)append:(NSDictionary * _Nonnull)properties;
		[Export ("append:")]
		void Append (NSDictionary properties);

		// -(void)union:(NSDictionary * _Nonnull)properties;
		[Export ("union:")]
		void Union (NSDictionary properties);

		// -(void)remove:(NSDictionary * _Nonnull)properties;
		[Export ("remove:")]
		void Remove (NSDictionary properties);

		// -(void)trackCharge:(NSNumber * _Nonnull)amount;
		[Export ("trackCharge:")]
		void TrackCharge (NSNumber amount);

		// -(void)trackCharge:(NSNumber * _Nonnull)amount withProperties:(NSDictionary * _Nullable)properties;
		[Export ("trackCharge:withProperties:")]
		void TrackCharge (NSNumber amount, [NullAllowed] NSDictionary properties);

		// -(void)clearCharges;
		[Export ("clearCharges")]
		void ClearCharges ();

		// -(void)deleteUser;
		[Export ("deleteUser")]
		void DeleteUser ();
	}

	// @protocol MixpanelType <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface MixpanelType
	{
		// @required -(BOOL)equalToMixpanelType:(id<MixpanelType>)rhs;
		[Abstract]
		[Export ("equalToMixpanelType:")]
		bool EqualToMixpanelType (MixpanelType rhs);
	}

	// @interface MixpanelTypeCategory (NSString) <MixpanelType>
	[Category]
	[BaseType (typeof(NSString))]
	interface NSString_MixpanelTypeCategory : IMixpanelType
	{
	}

	// @interface MixpanelTypeCategory (NSNumber) <MixpanelType>
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MixpanelTypeCategory : IMixpanelType
	{
	}

	// @interface MixpanelTypeCategory (NSArray) <MixpanelType>
	[Category]
	[BaseType (typeof(NSArray))]
	interface NSArray_MixpanelTypeCategory : IMixpanelType
	{
	}

	// @interface MixpanelTypeCategory (NSDictionary) <MixpanelType>
	[Category]
	[BaseType (typeof(NSDictionary))]
	interface NSDictionary_MixpanelTypeCategory : IMixpanelType
	{
	}

	// @interface MixpanelTypeCategory (NSDate) <MixpanelType>
	[Category]
	[BaseType (typeof(NSDate))]
	interface NSDate_MixpanelTypeCategory : IMixpanelType
	{
	}

	// @interface MixpanelTypeCategory (NSURL) <MixpanelType>
	[Category]
	[BaseType (typeof(NSUrl))]
	interface NSURL_MixpanelTypeCategory : IMixpanelType
	{
	}

	// @interface MixpanelGroup : NSObject
	[BaseType (typeof(NSObject))]
	interface MixpanelGroup
	{
		// -(void)set:(NSDictionary * _Nonnull)properties;
		[Export ("set:")]
		void Set (NSDictionary properties);

		// -(void)setOnce:(NSDictionary * _Nonnull)properties;
		[Export ("setOnce:")]
		void SetOnce (NSDictionary properties);

		// -(void)unset:(NSString * _Nonnull)property;
		[Export ("unset:")]
		void Unset (string property);

		// -(void)union:(NSString * _Nonnull)property values:(NSArray<id<MixpanelType>> * _Nonnull)values;
		[Export ("union:values:")]
		void Union (string property, MixpanelType[] values);

		// -(void)deleteGroup;
		[Export ("deleteGroup")]
		void DeleteGroup ();

		// -(void)remove:(NSString * _Nonnull)property value:(id<MixpanelType> _Nonnull)value;
		[Export ("remove:value:")]
		void Remove (string property, MixpanelType value);
	}

	// @interface Mixpanel : NSObject
	[BaseType (typeof(NSObject))]
	interface Mixpanel
	{
		// @property (readonly, atomic, strong) MixpanelPersistence * _Nonnull persistence;
		//[Export ("persistence", ArgumentSemantic.Strong)]
		//MixpanelPersistence Persistence { get; }

		// @property (readonly, atomic, strong) MixpanelPeople * _Nonnull people;
		[Export ("people", ArgumentSemantic.Strong)]
		MixpanelPeople People { get; }

		// @property (readonly, copy, atomic) NSString * _Nonnull distinctId;
		[Export ("distinctId")]
		string DistinctId { get; }

		// @property (readonly, copy, atomic) NSString * _Nonnull anonymousId;
		[Export ("anonymousId")]
		string AnonymousId { get; }

		// @property (readonly, copy, atomic) NSString * _Nonnull userId;
		[Export ("userId")]
		string UserId { get; }

		// @property (readonly, copy, atomic) NSString * _Nonnull alias;
		[Export ("alias")]
		string Alias { get; }

		// @property (assign, nonatomic) BOOL hadPersistedDistinctId;
		[Export ("hadPersistedDistinctId")]
		bool HadPersistedDistinctId { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull serverURL;
		[Export ("serverURL")]
		string ServerURL { get; set; }

		// @property (atomic) NSUInteger flushInterval;
		[Export ("flushInterval")]
		nuint FlushInterval { get; set; }

		// @property (atomic) BOOL flushOnBackground;
		[Export ("flushOnBackground")]
		bool FlushOnBackground { get; set; }

		// @property (atomic) BOOL shouldManageNetworkActivityIndicator;
		[Export ("shouldManageNetworkActivityIndicator")]
		bool ShouldManageNetworkActivityIndicator { get; set; }

		// @property (atomic) BOOL useIPAddressForGeoLocation;
		[Export ("useIPAddressForGeoLocation")]
		bool UseIPAddressForGeoLocation { get; set; }

		// @property (atomic) BOOL useUniqueDistinctId;
		[Export ("useUniqueDistinctId")]
		bool UseUniqueDistinctId { get; set; }

		// @property (nonatomic) BOOL trackAutomaticEventsEnabled;
		[Export ("trackAutomaticEventsEnabled")]
		bool TrackAutomaticEventsEnabled { get; set; }

		// @property (atomic) BOOL enableLogging;
		[Export ("enableLogging")]
		bool EnableLogging { get; set; }

		// @property (atomic) UInt64 minimumSessionDuration;
		[Export ("minimumSessionDuration")]
		ulong MinimumSessionDuration { get; set; }

		// @property (atomic) UInt64 maximumSessionDuration;
		[Export ("maximumSessionDuration")]
		ulong MaximumSessionDuration { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MixpanelDelegate Delegate { get; set; }

		// @property (atomic, weak) id<MixpanelDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// +(Mixpanel * _Nonnull)sharedInstanceWithToken:(NSString * _Nonnull)apiToken trackAutomaticEvents:(BOOL)trackAutomaticEvents;
		//[Static]
		//[Export ("sharedInstanceWithToken:trackAutomaticEvents:")]
		//Mixpanel SharedInstanceWithToken (string apiToken, bool trackAutomaticEvents);

		// +(Mixpanel * _Nonnull)sharedInstanceWithToken:(NSString * _Nonnull)apiToken trackAutomaticEvents:(BOOL)trackAutomaticEvents optOutTrackingByDefault:(BOOL)optOutTrackingByDefault;
		//[Static]
		//[Export ("sharedInstanceWithToken:trackAutomaticEvents:optOutTrackingByDefault:")]
		//Mixpanel SharedInstanceWithToken (string apiToken, bool trackAutomaticEvents, bool optOutTrackingByDefault);

		// +(Mixpanel * _Nonnull)sharedInstanceWithToken:(NSString * _Nonnull)apiToken trackAutomaticEvents:(BOOL)trackAutomaticEvents trackCrashes:(BOOL)trackCrashes;
		//[Static]
		//[Export ("sharedInstanceWithToken:trackAutomaticEvents:trackCrashes:")]
		//Mixpanel SharedInstanceWithToken (string apiToken, bool trackAutomaticEvents, bool trackCrashes);

		// +(Mixpanel * _Nonnull)sharedInstanceWithToken:(NSString * _Nonnull)apiToken trackAutomaticEvents:(BOOL)trackAutomaticEvents useUniqueDistinctId:(BOOL)useUniqueDistinctId;
		//[Static]
		//[Export ("sharedInstanceWithToken:trackAutomaticEvents:useUniqueDistinctId:")]
		//Mixpanel SharedInstanceWithToken (string apiToken, bool trackAutomaticEvents, bool useUniqueDistinctId);

		// +(Mixpanel * _Nonnull)sharedInstanceWithToken:(NSString * _Nonnull)apiToken trackAutomaticEvents:(BOOL)trackAutomaticEvents trackCrashes:(BOOL)trackCrashes optOutTrackingByDefault:(BOOL)optOutTrackingByDefault useUniqueDistinctId:(BOOL)useUniqueDistinctId;
		[Static]
		[Export ("sharedInstanceWithToken:trackAutomaticEvents:trackCrashes:optOutTrackingByDefault:useUniqueDistinctId:")]
		Mixpanel SharedInstanceWithToken (string apiToken, bool trackAutomaticEvents, bool trackCrashes, bool optOutTrackingByDefault, bool useUniqueDistinctId);

		// +(Mixpanel * _Nullable)sharedInstance;
		[Static]
		[NullAllowed, Export ("sharedInstance")]
		//[Verify (MethodToProperty)]
		Mixpanel SharedInstance { get; }

		// -(instancetype _Nonnull)initWithToken:(NSString * _Nonnull)apiToken trackAutomaticEvents:(BOOL)trackAutomaticEvents flushInterval:(NSUInteger)flushInterval trackCrashes:(BOOL)trackCrashes useUniqueDistinctId:(BOOL)useUniqueDistinctId;
		[Export ("initWithToken:trackAutomaticEvents:flushInterval:trackCrashes:useUniqueDistinctId:")]
		NativeHandle Constructor (string apiToken, bool trackAutomaticEvents, nuint flushInterval, bool trackCrashes, bool useUniqueDistinctId);

		// -(instancetype _Nonnull)initWithToken:(NSString * _Nonnull)apiToken trackAutomaticEvents:(BOOL)trackAutomaticEvents andFlushInterval:(NSUInteger)flushInterval;
		[Export ("initWithToken:trackAutomaticEvents:andFlushInterval:")]
		NativeHandle Constructor (string apiToken, bool trackAutomaticEvents, nuint flushInterval);

		// -(void)identify:(NSString * _Nonnull)distinctId;
		[Export ("identify:")]
		void Identify (string distinctId);

		// -(void)identify:(NSString * _Nonnull)distinctId usePeople:(BOOL)usePeople;
		[Export ("identify:usePeople:")]
		void Identify (string distinctId, bool usePeople);

		// -(void)addGroup:(NSString * _Nonnull)groupKey groupID:(id<MixpanelType> _Nonnull)groupID;
		[Export ("addGroup:groupID:")]
		void AddGroup (string groupKey, MixpanelType groupID);

		// -(void)removeGroup:(NSString * _Nonnull)groupKey groupID:(id<MixpanelType> _Nonnull)groupID;
		[Export ("removeGroup:groupID:")]
		void RemoveGroup (string groupKey, MixpanelType groupID);

		// -(void)setGroup:(NSString * _Nonnull)groupKey groupIDs:(NSArray<id<MixpanelType>> * _Nonnull)groupIDs;
		[Export ("setGroup:groupIDs:")]
		void SetGroup (string groupKey, MixpanelType[] groupIDs);

		// -(void)setGroup:(NSString * _Nonnull)groupKey groupID:(id<MixpanelType> _Nonnull)groupID;
		[Export ("setGroup:groupID:")]
		void SetGroup (string groupKey, MixpanelType groupID);

		// -(void)trackWithGroups:(NSString * _Nonnull)event properties:(NSDictionary * _Nonnull)properties groups:(NSDictionary * _Nonnull)groups;
		[Export ("trackWithGroups:properties:groups:")]
		void TrackWithGroups (string @event, NSDictionary properties, NSDictionary groups);

		// -(MixpanelGroup * _Nonnull)getGroup:(NSString * _Nonnull)groupKey groupID:(id<MixpanelType> _Nonnull)groupID;
		[Export ("getGroup:groupID:")]
		MixpanelGroup GetGroup (string groupKey, MixpanelType groupID);

		// -(void)track:(NSString * _Nonnull)event;
		[Export ("track:")]
		void Track (string @event);

		// -(void)track:(NSString * _Nonnull)event properties:(NSDictionary * _Nullable)properties;
		[Export ("track:properties:")]
		void Track (string @event, [NullAllowed] NSDictionary properties);

		// -(void)registerSuperProperties:(NSDictionary * _Nonnull)properties;
		[Export ("registerSuperProperties:")]
		void RegisterSuperProperties (NSDictionary properties);

		// -(void)registerSuperPropertiesOnce:(NSDictionary * _Nonnull)properties;
		[Export ("registerSuperPropertiesOnce:")]
		void RegisterSuperPropertiesOnce (NSDictionary properties);

		// -(void)registerSuperPropertiesOnce:(NSDictionary * _Nonnull)properties defaultValue:(id _Nullable)defaultValue;
		[Export ("registerSuperPropertiesOnce:defaultValue:")]
		void RegisterSuperPropertiesOnce (NSDictionary properties, [NullAllowed] NSObject defaultValue);

		// -(void)unregisterSuperProperty:(NSString * _Nonnull)propertyName;
		[Export ("unregisterSuperProperty:")]
		void UnregisterSuperProperty (string propertyName);

		// -(void)clearSuperProperties;
		[Export ("clearSuperProperties")]
		void ClearSuperProperties ();

		// -(NSDictionary * _Nonnull)currentSuperProperties;
		[Export ("currentSuperProperties")]
		//[Verify (MethodToProperty)]
		NSDictionary CurrentSuperProperties { get; }

		// -(void)timeEvent:(NSString * _Nonnull)event;
		[Export ("timeEvent:")]
		void TimeEvent (string @event);

		// -(double)eventElapsedTime:(NSString * _Nonnull)event;
		[Export ("eventElapsedTime:")]
		double EventElapsedTime (string @event);

		// -(void)clearTimedEvent:(NSString * _Nonnull)event;
		[Export ("clearTimedEvent:")]
		void ClearTimedEvent (string @event);

		// -(void)clearTimedEvents;
		[Export ("clearTimedEvents")]
		void ClearTimedEvents ();

		// -(void)reset;
		[Export ("reset")]
		void Reset ();

		// -(void)flush;
		[Export ("flush")]
		void Flush ();

		// -(void)flushWithCompletion:(void (^ _Nullable)(void))handler;
		[Export ("flushWithCompletion:")]
		void FlushWithCompletion ([NullAllowed] Action handler);

		// -(void)archive;
		[Export ("archive")]
		void Archive ();

		// -(void)createAlias:(NSString * _Nonnull)alias forDistinctID:(NSString * _Nonnull)distinctID;
		[Export ("createAlias:forDistinctID:")]
		void CreateAlias (string alias, string distinctID);

		// -(void)createAlias:(NSString * _Nonnull)alias forDistinctID:(NSString * _Nonnull)distinctID usePeople:(BOOL)usePeople;
		[Export ("createAlias:forDistinctID:usePeople:")]
		void CreateAlias (string alias, string distinctID, bool usePeople);

		// -(NSString * _Nonnull)libVersion;
		[Export ("libVersion")]
		//[Verify (MethodToProperty)]
		string LibVersion { get; }

		// -(void)optOutTracking;
		[Export ("optOutTracking")]
		void OptOutTracking ();

		// -(void)optInTracking;
		[Export ("optInTracking")]
		void OptInTracking ();

		// -(void)optInTrackingForDistinctID:(NSString * _Nullable)distinctID;
		[Export ("optInTrackingForDistinctID:")]
		void OptInTrackingForDistinctID ([NullAllowed] string distinctID);

		// -(void)optInTrackingForDistinctID:(NSString * _Nullable)distinctID withEventProperties:(NSDictionary * _Nullable)properties;
		[Export ("optInTrackingForDistinctID:withEventProperties:")]
		void OptInTrackingForDistinctID ([NullAllowed] string distinctID, [NullAllowed] NSDictionary properties);

		// -(BOOL)hasOptedOutTracking;
		[Export ("hasOptedOutTracking")]
		//[Verify (MethodToProperty)]
		bool HasOptedOutTracking { get; }

		// +(NSString * _Nonnull)libVersion;
		[Static]
		[Export ("libVersion")]
		//[Verify (MethodToProperty)]
		string LibStaticVersion { get; }
	}

	// @protocol MixpanelDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MixpanelDelegate
	{
		// @optional -(BOOL)mixpanelWillFlush:(Mixpanel * _Nonnull)mixpanel;
		[Export ("mixpanelWillFlush:")]
		bool MixpanelWillFlush (Mixpanel mixpanel);
	}
}
