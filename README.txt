d = InteropExample::Dog.new
d.class => Dog
d.walk 


f = InteropExample::AnimalFarm.new
c = f.get_animal "Cat" #-> base type - not interface

def walk_animal(a)
    a.walk
end

walk_animal d

walk_animal c

class InteropExample::Cat
   def walk()
      puts "No! I'm a cat"
   end
end



walk_animal InteropExample::Cat.new


f.say InteropExample::Dog.new
f.say InteropExample::Cat.new  #<-- goes to interface as expected

f.say "test"
f.say "test".ToString()
f.say [1,2,3,4]
f.say nil
