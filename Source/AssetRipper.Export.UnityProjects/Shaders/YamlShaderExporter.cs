﻿using AssetRipper.Assets;
using AssetRipper.Assets.Collections;
using AssetRipper.Assets.Export;
using AssetRipper.Export.UnityProjects.Project.Exporters;
using AssetRipper.SourceGenerated.Classes.ClassID_48;

namespace AssetRipper.Export.UnityProjects.Shaders
{
	/// <summary>
	/// An exporter for exporting shaders as unity assets. Shader.Find will not work in the Unity Editor with this exporter.
	/// </summary>
	public sealed class YamlShaderExporter : YamlExporterBase
	{
		public override bool TryCreateCollection(IUnityObjectBase asset, TemporaryAssetCollection temporaryFile, [NotNullWhen(true)] out IExportCollection? exportCollection)
		{
			exportCollection = asset switch
			{
				IShader shader => new YamlShaderExportCollection(this, shader),
				_ => null,
			};
			return exportCollection is not null;
		}
	}
}
