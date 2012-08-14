import unittest
from CLI.Console import Console

# Mocked STDOUT output.
class MockedConsole:
    def __init__(self):
        self.messages = []

    def getLastPrintedMessage(self):
        return self.messages[-1]

    def write(self, where, message):
        if message == "\n":
            value = self.getLastPrintedMessage() + "\n"
            self.messages = self.messages[:-1]
            self.messages.append(value)
        else:
            self.messages.append(message)


# Console outputter test case.
class TestClass(unittest.TestCase):
    def setUp(self):
        self.outputter = Console(MockedConsole(), "Name")

    def test_existance_output(self):
        assert self.outputter.output != None, "Output is None - missing STDOUT."

    def test_simple_print_message(self):
        message = "Simple information"
        self.outputter.printMessage(message)
        assert self.outputter.output.getLastPrintedMessage() == message, "You cannot print messages."

    def test_print_line(self):
        message = "Simple"
        self.outputter.printLine(message)
        assert self.outputter.output.getLastPrintedMessage() == "Simple\n", "You cannot print whole line."

    def test_print_separator(self):
        self.outputter.writeSeparatorLine()
        value = self.outputter.separator * self.outputter.separatorLength + "\n"
        assert self.outputter.output.getLastPrintedMessage() == value, "You can't print separator line."

    def test_which_checks_printing_headers(self):
        self.outputter.writeStartHeader()        
        assert self.outputter.output.getLastPrintedMessage().find("Name") != -1, "You can't print start header."

        self.outputter.writeEndHeader()
        value = self.outputter.separator * self.outputter.separatorLength + "\n"
        assert self.outputter.output.getLastPrintedMessage() == value, "You can't print ending header."

    def test_for_checking_steps(self):
        self.outputter.writeStep("1")
        assert self.outputter.output.getLastPrintedMessage() == "%s[ 1]\t1\n" % (self.outputter.defaultTabs)

        self.outputter.writeStep("2")
        assert self.outputter.output.getLastPrintedMessage() == "%s[ 2]\t2\n" % (self.outputter.defaultTabs)

    def test_for_writing_errors(self):
        self.outputter.writeError("ERROR")
        assert self.outputter.output.getLastPrintedMessage() == "%sERROR\n" % (self.outputter.defaultTabs)

    def test_for_increasing_indent(self):
        self.outputter.writeWithIndent("TEST")
        assert self.outputter.output.getLastPrintedMessage() == "\t\tTEST\n"

        self.outputter.increaseIndent()
        self.outputter.writeWithIndent("TEST")
        assert self.outputter.output.getLastPrintedMessage() == "\t\t\tTEST\n"

    def test_for_decreasing_indent(self):
        self.outputter.writeWithIndent("TEST")
        assert self.outputter.output.getLastPrintedMessage() == "\t\tTEST\n"

        self.outputter.decreaseIndent()
        self.outputter.writeWithIndent("TEST")
        assert self.outputter.output.getLastPrintedMessage() == "\tTEST\n"

    def test_for_decreasing_indent_below_zero(self):
        self.outputter.decreaseIndent()
        self.outputter.decreaseIndent()
        self.outputter.decreaseIndent()
        self.outputter.decreaseIndent()
        self.outputter.decreaseIndent()
        self.outputter.writeWithIndent("TEST")

        assert self.outputter.output.getLastPrintedMessage() == "TEST\n"
        assert self.outputter.tabsLength == 0