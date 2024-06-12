namespace Plugins.EmailSend.Models;

/// <summary>
///     The plugin configuration.
/// </summary>
public sealed record PluginConfig
{
	/// <summary>
	///     The name used to send an email. Optional
	/// </summary>
	public required string SmtpServer { get; init; }

	public int SmtpServerPort { get; init; } = 2525;

	/// <summary>
	///     The name used to send an email. Optional
	/// </summary>
	public required string SmtpUserName { get; init; }

	/// <summary>
	///     The name used to send an email. Optional
	/// </summary>
	public required string SmtpPassword { get; init; }

	/// <summary>
	///     The name used to send an email. Optional
	/// </summary>
	public string? SenderName { get; init; }

	/// <summary>
	/// The email used as sender in emails
	/// </summary>
	public required string SenderEmail { get; init; }
}
