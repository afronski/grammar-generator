# -*- coding: utf-8 -*-
#	Bachelor of Science Thesis				2o11/2o12
#	Author:									Wojciech Gawroński
#
#	Grammar Generator for internal searching language.
#	Main program.
#
#	Version:								1.0-kappa

import os
import sys
import subprocess

from CLI.Console import Console
from CLI.Invoker import Invoker
from Repositories.PartsRepository import PartsRepository
from Repositories.BaseRepository import BaseRepository
from Repositories.InputRepository import InputRepository
from Content.JsonContent import JsonContent
from IO.FileReader import FileReader
from IO.BufferedFileWriter import BufferedFileWriter
from Environment.RequirementsDetector import RequirementsDetector
from Builders.StringTemplateGroupFileBuilder import StringTemplateGroupFileBuilder
from Builders.GrammarFileBuilder import GrammarFileBuilder

class Generator:
	def __init__(self):
		self.detector = RequirementsDetector(subprocess)
		self.console = Console(os, "Grammar Generator")

		self.ToolPath = "ANTLR/antlr-3.1.3.jar"
		self.OutputPath = "Output"
		self.OutputFileName = "FiltersLanguageGrammar"
		self.Output = {
			"G"   : (".g", BufferedFileWriter(self.OutputPath)),
			"STG" : (".stg", BufferedFileWriter(self.OutputPath))
		}

		self.modules = {}
		self.parts = {}
		self.base = {}

		self.targetsAndRepositories = [ 
			(self.parts, PartsRepository()),
			(self.base, BaseRepository()), 
			(self.modules, InputRepository()) 
		]

		self.ModulesObjects = {}

	def verifyRequirements(self):
		if not self.detector.isJavaRuntimeEnvironmentPresent():
			raise EnvironmentError("Missing JRE in system - please install at least version 1.6.")

	def fillDictionaries(self):
		reader = FileReader()

		for target, repository in self.targetsAndRepositories:
			for fileFromRepository in repository.loadAll():
				name = self.onlyFileName(fileFromRepository)
				target[name] = reader.getContent(fileFromRepository)

	def onlyFileName(self, path):
		return os.path.splitext(os.path.basename(path))[0]

	def parseAndValidateModules(self):
		for name, content in self.modules.iteritems():
			stringifiedSettings = JsonContent(content)

			if stringifiedSettings.validate():
				self.ModulesObjects[name] = stringifiedSettings.parse()
			else:
				raise AttributeError("Module named '%s' has invalid syntax - JSON validation error." % (name))
	
	def buildG(self):
		GrammarFileBuilder(
			self.Output["G"][1],
			self.ModulesObjects,
			self.parts,
			self.base["G"],
			self.console
		).generate()
				
	def buildStg(self):
		StringTemplateGroupFileBuilder(
			self.Output["STG"][1],
			self.ModulesObjects,
			self.parts,
			self.base["STG"],
			self.console
		).generate()

	def saveAllFiles(self):
		for extension, writer in self.Output.values():
			writer.saveWithFileName(self.OutputFileName + extension)

	def getInputFileName(self):
		extension = self.Output["G"][0]
		return self.OutputFileName + extension

	def getToolParameters(self):				
		inputPath = os.path.join(self.OutputPath, self.getInputFileName())

		return [
			'-cp', self.ToolPath, 
			'org.antlr.Tool', 
			'-verbose',
			'-report',
			'-fo', self.OutputPath,
			inputPath
		]

	def getToolErrorMessage(self, processResponse):
		EOL = '\n'
		parameters = (EOL * 2, processResponse["stderr"])

		return "ANTLR exception has ocurred. Details:%s%s" % parameters

	def invokeTool(self):
		invoker = Invoker(subprocess)
		result = invoker.executeCommandWithParams('java', *self.getToolParameters())

		if result["ReturnCode"] != 0:
			raise EnvironmentError(self.getToolErrorMessage(result))

	def run(self):	
		try:		
			self.console.writeStartHeader()

			self.console.writeStep("Verifying environment")
			self.verifyRequirements()

			self.console.writeStep("Reading files")
			self.fillDictionaries()

			self.console.writeStep("Validating")
			self.parseAndValidateModules()

			self.console.writeStep("Building G file")
			self.buildG()

			self.console.writeStep("Building STG file")
			self.buildStg()

			self.console.writeStep("Saving output files")
			self.saveAllFiles()

			self.console.writeStep("Invoking ANTLR")
			self.invokeTool()

			self.console.writeStep("Finished!")
			self.console.writeEndHeader()
		except AttributeError as (errorMessage):
			self.console.writeError("ATTRIBUTE ERROR: %s" % (errorMessage))
		except EnvironmentError as (errorMessage):
			self.console.writeError("ENVIRONMENT ERROR: %s" % (errorMessage))
		except IOError as (errorNumber, errorMessage):			
			self.console.writeError("I/O ERROR [%d]: %s" % (errorNumber, errorMessage))

if __name__ == '__main__':
	Generator().run()