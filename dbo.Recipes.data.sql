DROP TABLE IF EXISTS Recipes;

-- Créer la table Recipes
CREATE TABLE Recipes (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(MAX),
    Time INT,
    Difficulty NVARCHAR(MAX),
    Number_of_likes INT,
    Ingredients NVARCHAR(MAX),
    Process NVARCHAR(MAX),
    Tips_and_Tricks NVARCHAR(MAX)
);

-- Insérer des données dans la table Recipes
INSERT INTO Recipes (Name, Time, Difficulty, Number_of_likes, Ingredients, Process, Tips_and_Tricks)
VALUES 
    ('Spaghetti Carbonara', 30, 'Medium', 500, '200g spaghetti\r\n150g pancetta or bacon, diced\r\n2 large eggs\r\n50g grated Parmesan cheese\r\n50g grated Pecorino Romano cheese\r\nFreshly ground black pepper', 'Cook spaghetti according to package instructions until al dente. Reserve 1/2 cup of pasta water before draining.\r\nIn a separate pan, cook diced pancetta or bacon until crispy.\r\nIn a bowl, whisk together eggs, Parmesan cheese, and Pecorino Romano cheese.\r\nAdd cooked spaghetti to the pan with pancetta/bacon. Remove from heat and quickly toss to coat the pasta.\r\nPour the egg and cheese mixture over the pasta, stirring quickly to combine. The residual heat will cook the eggs and create a creamy sauce. If too dry, add reserved pasta water a little at a time.\r\nSeason with freshly ground black pepper to taste.', 'Make sure the pan is off the heat when adding the egg and cheese mixture to avoid scrambling the eggs.\r\nUse high-quality Parmesan and Pecorino Romano cheese for the best flavor.\r\nIf you prefer a smoother sauce, you can use only Parmesan cheese instead of a combination of Parmesan and Pecorino Romano.'),
    ('Margherita Pizza', 60, 'Easy', 1000, '1 pre-made pizza dough (store-bought or homemade)\r\n1/2 cup pizza sauce\r\n8 oz fresh mozzarella cheese, sliced\r\nFresh basil leaves, torn\r\nExtra virgin olive oil\r\nSalt and pepper to taste', 'Preheat the oven to 475°F (245°C).\r\nRoll out the pizza dough on a floured surface to your desired thickness.\r\nTransfer the rolled-out dough to a pizza stone or baking sheet lined with parchment paper.\r\nSpread the pizza sauce evenly over the dough, leaving', 'For a crispier crust, pre-bake the dough for 5-7 minutes before adding toppings.\r\nUse fresh mozzarella cheese for the best flavor and texture.\r\nIf you prefer, you can add other toppings such as sliced tomatoes, olives, or thinly sliced onions before baking.');
