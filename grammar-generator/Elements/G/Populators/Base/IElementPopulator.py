from Content.TemplateResolver import TemplateResolver

class IElementPopulator(object):
	def __init__(self, sectionName, templates, settingsObject):
		self.name = sectionName
		self.templates = templates
		self.parameters = settingsObject

		self.notImplementedTemplatePostFix = "-NotImplemented"

		self.templateName = sectionName.split('_')[-1]
		self.settingName = self.templateName.split('-')[0]		

		self.passedNotImplementedTemplateName = ""

		if self.templateName.find("$") != -1:
			splittedElements = self.templateName.split('$')
			
			self.templateName = splittedElements[0]
			self.passedNotImplementedTemplateName = splittedElements[1]

		if not self.templates.has_key(self.templateName):
			messageArguments = (self.templateName, self.name)
			raise AttributeError("Missing template (%s) for specified section '%s'" % messageArguments)

		self.templateResolver = TemplateResolver(self.templates, self.templateName)

	def expandParameters(self, parameter):
		parametersForExpansion = [ "ModuleShortName", "ModuleLongName", "ModulePrefix" ]

		for parameterName in parametersForExpansion:
			parameter[parameterName] = self.parameters[parameterName]

		parameter["PostFix"] = parameter["Name"]

		return parameter

	def handleNotImplementedTemplates(self, names, objectSettings):
		if len(names) > 0:
			for notImplementedKeyName in names:
				if objectSettings.has_key(notImplementedKeyName):
					if self.templates.has_key(self.templateName + self.notImplementedTemplatePostFix):
						self.templateName += self.notImplementedTemplatePostFix		
						self.templateResolver = TemplateResolver(self.templates, self.templateName)
						break

	def restoreDefault(self):
		self.templateName = self.templateName.replace(self.notImplementedTemplatePostFix, "")
		self.templateResolver = TemplateResolver(self.templates, self.templateName)

	def getType(self):
		raise NotImplementedError("IElementPopulator is an abstract class.")

	def populate(self):
		raise NotImplementedError("IElementPopulator is an abstract class.")		