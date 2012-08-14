from Elements.G.Populators.OnlyEntriesPopulator import OnlyEntriesPopulator
from Elements.G.Populators.ParameterListPopulator import ParameterListPopulator
from Elements.G.Populators.OnlyMainEntryPopulator import OnlyMainEntryPopulator
from Elements.G.Populators.OnlyBooleanEntriesPopulator import OnlyBooleanEntriesPopulator
from Elements.G.Populators.OnlyEntriesForListPopulator import OnlyEntriesForListPopulator
from Elements.G.Populators.AllParametersListPopulator import AllParametersListPopulator
from Elements.G.Populators.AllParametersListWithOneNamePopulator import AllParametersListWithOneNamePopulator
from Elements.G.Populators.OneEntryForTemplatePopulator import OneEntryForTemplatePopulator
from Elements.G.Populators.OneEntryForTemplateWithNamePopulator import OneEntryForTemplateWithNamePopulator

class ElementsPopulatorFactory:
	def create(self, populatorName, sectionName, templates, settingsObject):
		if populatorName == "CreateEntriesOnly":
			return OnlyEntriesPopulator(sectionName, templates, settingsObject)
		elif populatorName == "CreateEntriesForListOnly":
			return OnlyEntriesForListPopulator(sectionName, templates, settingsObject)			
		elif populatorName == "CreateBooleanEntriesOnly":
			return OnlyBooleanEntriesPopulator(sectionName, templates, settingsObject)
		elif populatorName == "CreateMainEntryOnly":
			return OnlyMainEntryPopulator(sectionName, templates, settingsObject)
		elif populatorName == "CreateParametersListWithName":			
			return ParameterListPopulator(sectionName, templates, settingsObject)
		elif populatorName == "CreateAllParametersListWithName":			
			return AllParametersListPopulator(sectionName, templates, settingsObject)			
		elif populatorName == "CreateAllParametersListWithOneName":			
			return AllParametersListWithOneNamePopulator(sectionName, templates, settingsObject)						
		elif populatorName == "CreateOneEntryForTemplate":
			return OneEntryForTemplatePopulator(sectionName, templates, settingsObject)
		elif populatorName == "CreateOneEntryForTemplateWithName":
			return OneEntryForTemplateWithNamePopulator(sectionName, templates, settingsObject)
		else:
			return None