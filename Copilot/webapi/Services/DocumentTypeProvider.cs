// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;

using Microsoft.KernelMemory.Pipeline;

namespace CopilotChat.WebApi.Services;

/// <summary>
///     Defines a service that performs content safety analysis on images.
/// </summary>
public sealed class DocumentTypeProvider
{
	private readonly HashSet<string> _supportedTypes = new(StringComparer.OrdinalIgnoreCase)
		{
			FileExtensions.MarkDown,
			FileExtensions.MsWord,
			FileExtensions.MsWordX,
            FileExtensions.CSVData,
			FileExtensions.Pdf,
			FileExtensions.PlainText,
			FileExtensions.AudioWaveform,
			FileExtensions.AudioOpus,
			FileExtensions.AudioMP3,
			FileExtensions.AudioAAC,
			FileExtensions.AudioOGG,
			FileExtensions.AudioWEBM,
			FileExtensions.VideoMP4,
			FileExtensions.VideoOGG,
			FileExtensions.VideoMPEG,
			FileExtensions.VideoWEBM,
			FileExtensions.VideoOGGGeneric
		};

	/// <summary>
	///     Returns true if the extension is supported for import.
	/// </summary>
	/// <param name="extension">The file extension</param>
	/// <returns></returns>
	public bool IsSupported(string extension)
	{
		return _supportedTypes.Contains(extension);
	}
}
