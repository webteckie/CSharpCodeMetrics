# Code Metrics

## Class coupling
- Measures the coupling to unique classes through parameters, local variables, return types, method calls, 
generic or template instantiations, base classes, interface implementations, fields defined on external types, and
attribute decoration.
- A high number is bad and a low number is generally good with this metric.
- Class coupling has been shown to be an accurate predictor of software failure and recent studies have shown that an upper-limit value of 9 is the most efficient.
- Good software design dictates that types and methods should have high cohesion and low coupling. 

### High coupling
High coupling indicates a design that is difficult to reuse and maintain because of its many interdependencies on other types.


### Module cohesion
- Module cohesion is how tightly bound or related the internal elements of a module are to one another.
- A module has a strong cohesion if it represents exactly one task, and all its elements contribute to this single task (single responsibility).
- They describe cohesion as an attribute of design, rather than code, and an attribute that can be used to predict reusability, maintainability, and changeability.


## Cyclomatic Complexity
- It is the number of independent paths throughout the source code. 
- Gives a sense of how hard any given code may be to test and maintain.
- May dictate how likely the code is to produce errors and the complexity in troubleshooting those errors. 
- Modules with high numbers (15+) should prompt the module to be analyzed for possible unnecessary paths.
- Modules with numbers between 10 and 15 are considered OK.
- Should aim for not higher than 10 per module.


## Depth of Inheritance
- It is the maximum length from the leaf node to the root of the tree.
- Depth of inheritance is predicated on three fundamental assumptions:

1. The deeper a class in the hierarchy, the greater the number of methods it will probably inherit which makes it harder to predict its behavior.
2. Deeper trees involve greater design complexity since more classes and methods are involved.
3. Deeper classes in the tree have a greater potential for reusing inherited methods.

- Assumptions 1 and 2 tell us that having a higher number for depth is bad.
- Assumption 3, however, indicates that a higher number for depth indicates desire for code reuse (but better using dependency injection).


## Maintainability Index
- Represents the relative ease of maintaining the code.
- The value is an index value between 0 and 100.
- A high value means better maintainability; a low value means bad maintainability.
- Color coded ratings (which VS uses) can be used to quickly identify trouble spots in your code:
1. A green rating is between 20 and 100 and indicates that the code has good maintainability. 
2. A yellow rating is between 10 and 19 and indicates that the code is moderately maintainable. 
3. A red rating is a rating between 0 and 9 and indicates low maintainability.


## Linked Sources
https://blogs.msdn.microsoft.com/zainnab/2011/05/25/code-metrics-class-coupling/

https://blogs.msdn.microsoft.com/zainnab/2011/05/17/code-metrics-cyclomatic-complexity/

https://blogs.msdn.microsoft.com/zainnab/2011/05/19/code-metrics-depth-of-inheritance-dit/

https://blogs.msdn.microsoft.com/zainnab/2011/05/26/code-metrics-maintainability-index/