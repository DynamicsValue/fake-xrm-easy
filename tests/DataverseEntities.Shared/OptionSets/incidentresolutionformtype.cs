#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataverseEntities
{
	
	
	/// <summary>
	/// Option set for the different possible forms to use for incident/case resolution
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum incidentresolutionformtype
	{
		
		/// <summary>
		/// MDD
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Standarddialog = 1,
		
		/// <summary>
		/// MFD
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Customizabledialog = 2,
		
		/// <summary>
		/// Quick create form
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Quickcreatedialog = 3,
	}
}
#pragma warning restore CS1591
