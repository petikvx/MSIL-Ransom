using System;
using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common;

public interface IPlatformClient
{
	CoreClient Core { get; }

	bool ApplicationStart([Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] IFlowController flowController);

	void ApplicationStop([Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] bool immediate);

	void ApplicationStopSync([Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] bool immediate);

	void ApplicationStopAsync([Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] bool immediate);

	void FeatureTick(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);

	void FeatureStart(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary, [Optional] Guid? group);

	void FeatureStartWithGroup(string name, Guid group, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);

	void FeatureStopWithGroup(string name, Guid group, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);

	void FeatureStop(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary, [Optional] Guid? group);

	void ReportException(ExceptionInfo exceptionInfo);

	void ReportException(ExceptionInfo exceptionInfo, ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);

	void ReportException(ExceptionInfo exceptionInfo, bool optInOverride, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);

	void SystemProfile([Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);

	void PerformanceProbe(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo info);

	Guid NewFeatureGroup();

	void SetSendDisabled(bool value);

	void SendMessages();

	void SetSessionOptIn(bool value);

	void ReportTamper([Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);

	void ReportDebugging([Optional] bool optinOverride, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);

	void ReportExpiration(Guid slid, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);

	void ReportExpirationWarning(Guid slid, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary);
}
