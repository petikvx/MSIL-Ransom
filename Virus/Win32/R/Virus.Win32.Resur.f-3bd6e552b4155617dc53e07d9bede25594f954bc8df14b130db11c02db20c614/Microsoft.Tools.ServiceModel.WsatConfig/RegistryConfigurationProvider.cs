using Microsoft.Win32;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class RegistryConfigurationProvider : ConfigurationProvider
{
	private StdRegProviderWrapper stdRegProvider;

	internal RegistryConfigurationProvider(RegistryHive remoteHive, string subKey, string machineName)
	{
		stdRegProvider = new StdRegProviderWrapper(remoteHive, subKey, machineName);
	}

	private RegistryConfigurationProvider(StdRegProviderWrapper stdRegProvider)
	{
		this.stdRegProvider = stdRegProvider;
	}

	internal override ConfigurationProvider OpenKey(string subKey)
	{
		StdRegProviderWrapper stdRegProviderWrapper = stdRegProvider.OpenKey(subKey);
		return new RegistryConfigurationProvider(stdRegProviderWrapper);
	}

	internal override uint ReadUInt32(string name, uint defaultValue)
	{
		return stdRegProvider.ReadUInt32(name, defaultValue);
	}

	internal override string ReadString(string name, string defaultValue)
	{
		return stdRegProvider.ReadString(name, defaultValue);
	}

	internal override string[] ReadMultiString(string name, string[] defaultValue)
	{
		return stdRegProvider.ReadMultiString(name, defaultValue);
	}

	internal override void WriteUInt32(string name, uint value)
	{
		stdRegProvider.WriteUInt32(name, value);
	}

	internal override void WriteString(string name, string value)
	{
		stdRegProvider.WriteString(name, value);
	}

	internal override void WriteMultiString(string name, string[] value)
	{
		stdRegProvider.WriteMultiString(name, value);
	}

	internal override void AdjustRegKeyPermission()
	{
		stdRegProvider.AdjustRegKeyPermission();
	}

	public override void Dispose()
	{
		if (stdRegProvider != null)
		{
			stdRegProvider.Dispose();
			stdRegProvider = null;
		}
	}
}
