from Elements.G.Populators.Base.IElementPopulator import IElementPopulator

class OneEntryForTemplatePopulator(IElementPopulator):
	def __init__(self, sectionName, templates, settingsObject):
		super(OneEntryForTemplatePopulator, self).__init__(sectionName, templates, settingsObject)

	def getType(self):
		return "CreateOneEntryForTemplate"

	def createParameters(self):
		parameter = {}
		parametersForExpansion = [ "ModuleShortName", "ModuleLongName", "ModulePrefix" ]

		for parameterName in parametersForExpansion:
			parameter[parameterName] = self.parameters[parameterName]

		parameter["PostFix"] = self.settingName.lower()

		return parameter

	def populate(self):
		return self.templateResolver.fill(self.createParameters())