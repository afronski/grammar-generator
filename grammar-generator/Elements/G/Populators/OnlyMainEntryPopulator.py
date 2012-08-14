from Elements.G.Populators.Base.IElementPopulator import IElementPopulator

class OnlyMainEntryPopulator(IElementPopulator):
	def __init__(self, sectionName, templates, settingsObject):
		super(OnlyMainEntryPopulator, self).__init__(sectionName, templates, settingsObject)

	def getType(self):
		return "CreateMainEntryOnly"

	def populate(self):
		return self.templateResolver.fill(self.parameters)