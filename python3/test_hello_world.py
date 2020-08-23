import unittest

from hello_world import hello_world

class HelloWorldTest(unittest.TestCase):
  def test_hello_world(self):
    expected_result = "hello world"
    actual_result = hello_world()
    self.assertEqual(expected_result, actual_result)
