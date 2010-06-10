require 'Example\bin\Debug\example.dll'
include Example

m = Manager.new
a = Assistant.new

p = PayRoll.new
p.pay a
p.pay m

class Developer < Employee
  def Salary
    10
  end
end

p.pay Developer.new
p.pay "My string"


new_employee = p.generate_new_employee 'Assistant'
puts new_employee.class
p.pay new_employee
