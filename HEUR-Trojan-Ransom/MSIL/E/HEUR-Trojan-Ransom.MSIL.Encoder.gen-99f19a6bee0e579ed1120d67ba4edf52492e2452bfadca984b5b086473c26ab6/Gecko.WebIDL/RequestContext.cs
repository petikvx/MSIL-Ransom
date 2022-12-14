using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RequestContext
{
	[Description("audio")]
	audio,
	[Description("beacon")]
	beacon,
	[Description("cspreport")]
	cspreport,
	[Description("download")]
	download,
	[Description("embed")]
	embed,
	[Description("eventsource")]
	eventsource,
	[Description("favicon")]
	favicon,
	[Description("fetch")]
	fetch,
	[Description("font")]
	font,
	[Description("form")]
	form,
	[Description("frame")]
	frame,
	[Description("hyperlink")]
	hyperlink,
	[Description("iframe")]
	iframe,
	[Description("image")]
	image,
	[Description("imageset")]
	imageset,
	[Description("import")]
	import,
	[Description("internal")]
	@internal,
	[Description("location")]
	location,
	[Description("manifest")]
	manifest,
	[Description("object")]
	@object,
	[Description("ping")]
	ping,
	[Description("plugin")]
	plugin,
	[Description("prefetch")]
	prefetch,
	[Description("script")]
	script,
	[Description("sharedworker")]
	sharedworker,
	[Description("subresource")]
	subresource,
	[Description("style")]
	style,
	[Description("track")]
	track,
	[Description("video")]
	video,
	[Description("worker")]
	worker,
	[Description("xmlhttprequest")]
	xmlhttprequest,
	[Description("xslt")]
	xslt
}
