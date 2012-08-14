from Elements.STG.Filtering.DateElementForStg import DateElementForStg
from Elements.STG.Filtering.StandardElementForStg import StandardElementForStg

class StgFilteringElementsFactory:
	def create(self, name, templates, settingsObject):
		hasDateInName = name.find("Date") != -1
		hasParametersInName = name.find("Parameters") != -1

		if hasParametersInName:
			if hasDateInName:
				return DateElementForStg(templates, settingsObject)
			else:
				return StandardElementForStg(templates, settingsObject)
		
		return None