using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaStoryCountdownStickerItem
{
	public long CountdownId { get; set; }

	public DateTime EndTime { get; set; }

	public string Text { get; set; }

	public string TextColor { get; set; }

	public string StartBackgroundColor { get; set; }

	public string EndBackgroundColor { get; set; }

	public string DigitColor { get; set; }

	public string DigitCardColor { get; set; }

	public bool FollowingEnabled { get; set; }

	public bool IsOwner { get; set; }

	public bool ViewerIsFollowing { get; set; }
}
