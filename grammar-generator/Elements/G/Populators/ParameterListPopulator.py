from Content.TemplateResolver import TemplateResolver
from Elements.G.Populators.Base.IElementPopulator import IElementPopulator

class ParameterListPopulator(IElementPopulator):
	def __init__(self, sectionName, templates, settingsObject):
		self.name = sectionName
		self.templates = templates
		self.parameters = settingsObject

		splittedSectionName = sectionName.split('_')[-1]
		splittedTemplateName = splittedSectionName.split('-')

		self.templateName = splittedTemplateName[0]
		self.settingName = splittedTemplateName[1]

		if not self.templates.has_key(self.templateName):
			messageArguments = (self.templateName, self.name)
			raise AttributeError("Missing template (%s) for specified section '%s'" % messageArguments)

		self.templateResolver = TemplateResolver(self.templates, self.templateName)	
		self.separator = "|\n"

	def getType(self):
		return "CreateParametersListWithName"

	def openClause(self):
		return self.parameters["ModulePrefix"] + "_" + self.settingName.lower() + ":\n"

	def closeClause(self):
		return "\n;"

	def populate(self):
		result = self.openClause()

		blocks = []
		for settingName, setting in self.parameters.iteritems():
			if settingName.find("Parameters") != -1:
				for parameterName, parameter in setting.iteritems():				
					blocks.append(self.templateResolver.fill(self.expandParameters(parameter)))

		result += self.separator.join(blocks)
		result += self.closeClause()

		return result
