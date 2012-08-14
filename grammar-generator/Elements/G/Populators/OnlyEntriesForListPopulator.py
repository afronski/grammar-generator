from Elements.G.Populators.Base.IElementPopulator import IElementPopulator

class OnlyEntriesForListPopulator(IElementPopulator):
	def __init__(self, sectionName, templates, settingsObject):
		super(OnlyEntriesForListPopulator, self).__init__(sectionName, templates, settingsObject)
		self.separator = "\n|\n"

	def getType(self):
		return "CreateEntriesOnly"

	def populate(self):
		return self.separator.join([ self.templateResolver.fill(self.expandParameters(parameter))
											for parameterName, parameter in 
												self.parameters[self.settingName].iteritems() ])