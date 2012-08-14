from Content.TemplateResolver import TemplateResolver
from Elements.G.Populators.Base.IElementPopulator import IElementPopulator

class OnlyBooleanEntriesPopulator(IElementPopulator):
	def __init__(self, sectionName, templates, settingsObject):
		self.name = sectionName
		self.templates = templates
		self.parameters = settingsObject

		self.templateName = sectionName.split('_')[-1]
		nameElements = self.templateName.split('-')

		self.settingName = nameElements[0]
		self.fieldName = nameElements[1]

		self.separator = ",\n"

	def getType(self):
		return "CreateBooleanEntriesOnly"

	def populate(self):
		result = []

		for parameterName, parameter in self.parameters[self.settingName].iteritems():
			for attributeName, attribute in parameter.iteritems():
				if attributeName == self.fieldName:
					nameForResolving = self.templateName + "$%r" % (attribute)
					expanded = self.expandParameters(parameter)

					self.templateResolver = TemplateResolver(self.templates, nameForResolving)
					result.append(self.templateResolver.fill(expanded))

		return self.separator.join(result)