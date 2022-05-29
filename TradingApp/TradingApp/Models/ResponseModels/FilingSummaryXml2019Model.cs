namespace TradingApp.Models.ResponseModels
{
	using System;
	using System.Xml.Serialization;
	using System.Collections.Generic;

	[Serializable, XmlRoot(ElementName = "Report")]
	public class Report
	{
		[XmlElement(ElementName = "IsDefault")]
		public string IsDefault { get; set; }
		[XmlElement(ElementName = "HasEmbeddedReports")]
		public string HasEmbeddedReports { get; set; }
		[XmlElement(ElementName = "HtmlFileName")]
		public string HtmlFileName { get; set; }
		[XmlElement(ElementName = "LongName")]
		public string LongName { get; set; }
		[XmlElement(ElementName = "ReportType")]
		public string ReportType { get; set; }
		[XmlElement(ElementName = "Role")]
		public string Role { get; set; }
		[XmlElement(ElementName = "ShortName")]
		public string ShortName { get; set; }
		[XmlElement(ElementName = "MenuCategory")]
		public string MenuCategory { get; set; }
		[XmlElement(ElementName = "Position")]
		public string Position { get; set; }
		[XmlAttribute(AttributeName = "instance")]
		public string Instance { get; set; }
		[XmlElement(ElementName = "ParentRole")]
		public string ParentRole { get; set; }
	}

	[XmlRoot(ElementName = "MyReports")]
	public class MyReports
	{
		[XmlElement(ElementName = "Report")]
		public List<Report> Reports { get; set; }
	}

	[XmlRoot(ElementName = "InputFiles")]
	public class InputFiles
	{
		[XmlElement(ElementName = "File")]
		public List<string> File { get; set; }
	}

	[XmlRoot(ElementName = "BaseTaxonomies")]
	public class BaseTaxonomies
	{
		[XmlElement(ElementName = "BaseTaxonomy")]
		public List<string> BaseTaxonomy { get; set; }
	}

	[XmlRoot(ElementName = "FilingSummary")]
	public class FilingSummary2019
	{
		[XmlElement(ElementName = "Version")]
		public string Version { get; set; }
		[XmlElement(ElementName = "ProcessingTime")]
		public string ProcessingTime { get; set; }
		[XmlElement(ElementName = "ReportFormat")]
		public string ReportFormat { get; set; }
		[XmlElement(ElementName = "ContextCount")]
		public string ContextCount { get; set; }
		[XmlElement(ElementName = "ElementCount")]
		public string ElementCount { get; set; }
		[XmlElement(ElementName = "EntityCount")]
		public string EntityCount { get; set; }
		[XmlElement(ElementName = "FootnotesReported")]
		public string FootnotesReported { get; set; }
		[XmlElement(ElementName = "SegmentCount")]
		public string SegmentCount { get; set; }
		[XmlElement(ElementName = "ScenarioCount")]
		public string ScenarioCount { get; set; }
		[XmlElement(ElementName = "TuplesReported")]
		public string TuplesReported { get; set; }
		[XmlElement(ElementName = "UnitCount")]
		public string UnitCount { get; set; }
		[XmlElement(ElementName = "MyReports")]
		public MyReports MyReports { get; set; }
		[XmlElement(ElementName = "InputFiles")]
		public InputFiles InputFiles { get; set; }
		[XmlElement(ElementName = "SupplementalFiles")]
		public string SupplementalFiles { get; set; }
		[XmlElement(ElementName = "BaseTaxonomies")]
		public BaseTaxonomies BaseTaxonomies { get; set; }
		[XmlElement(ElementName = "HasPresentationLinkbase")]
		public string HasPresentationLinkbase { get; set; }
		[XmlElement(ElementName = "HasCalculationLinkbase")]
		public string HasCalculationLinkbase { get; set; }
	}

}


