from Elements.G.Transformers.ForEachModuleSectionTransformer import ForEachModuleSectionTransformer
from Elements.G.Transformers.ForEachModuleSectionTransformerWithPipe import ForEachModuleSectionTransformerWithPipe
from Elements.G.Transformers.ForEachModuleSectionTransformerWithComma import ForEachModuleSectionTransformerWithComma

class SectionTransformerFactory:
	def create(self, sectionName, templates, settingsObject):
		sectionNameParts = sectionName.split('_')
		isItSectionForTransformingEachModule = sectionName.find("ForEachModule_") != -1
		isItSectionForTransformingEachModuleWithPipe = sectionName.find("ForEachModuleWithPipe_") != -1
		isItSectionForTransformingEachModuleWithComma = sectionName.find("ForEachModuleWithComma_") != -1

		if len(sectionNameParts) < 3:
			raise AttributeError("Missing SectionName parameters passed by '%s'." % (sectionName))

		if isItSectionForTransformingEachModule:
			return ForEachModuleSectionTransformer(sectionName, templates, settingsObject)		
		elif isItSectionForTransformingEachModuleWithPipe:
			return ForEachModuleSectionTransformerWithPipe(sectionName, templates, settingsObject)
		elif isItSectionForTransformingEachModuleWithComma:
			return ForEachModuleSectionTransformerWithComma(sectionName, templates, settingsObject)			
		else:
			return None