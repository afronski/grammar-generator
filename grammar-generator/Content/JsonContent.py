import json

class JsonContent:
	def __init__(self, content):
		self.content = content

	def validate(self):
		result = True

		try:
			json.loads(self.content)
		except ValueError:
			result = False

		return result
	
	def parse(self):
		result = self.validate()

		if result:
			return json.loads(self.content)
		else:
			return None