![Blazor Banner](https://www.campusmvp.es/catalogo/repository/product/curso-blazor-online.png?v=0.0.1)
# Blazor Web Assembly Project - Recipe App

This project is a web-based application for creating, editing, and storing recipes. The app is built using Blazor Web Assembly, a framework for building client-side web applications with .NET and C#. With this app, users can easily add new recipes, edit existing ones, and view a list of all their recipes in one convenient location.

# Objectives

The main objectives of this project are:

1.  To provide a user-friendly web application for managing and organizing recipes.
2.  To utilize the capabilities of Blazor Web Assembly and C# to build a responsive and interactive app.
3.  To create a platform for storing and accessing recipes from any device with an internet connection.

# Progression

Day 1: the following progress was made on the recipe app:

- The "add recipe", "edit recipe", and "list of recipe" pages were implemented and added to the navbar

![Day 1](https://gcdnb.pbrd.co/images/Oe3jUgIfDL12.png?o=1)

Day 2: further development was completed on the "add recipe" page, which now includes a form with fields for the name of the recipe, ingredients, and time needed to complete the recipe, as well as an "add recipe" button. A screenshot of this page can be seen below:

![Day 2](https://gcdnb.pbrd.co/images/Aa3bIHECpNRV.png?o=1)

Day 3: the data is now stored in the LocalStorage. When submitting the recipe, the data is stored in an array.
So when we refresh the page, the data will be visible. The data are no longer volatile.

![Day 3](https://i.ibb.co/J2SjzKz/2023-02-05-22-35-36-List-of-Recipes.png)

Day 4: the recipes can be now displayed  in the "Add Recipe" navbar. It can also be edited and deleted dynamically thanks to the methods DeleteRecipeAsync.

![Day 4](https://i.ibb.co/F8PG9sC/2023-02-05-22-33-48-List-of-Recipes.png)

Day 5: The design of the app has been reworked. The library Blazorise has been used to get a better design of the app with more functionnality. Here is the result: 

![Day 5](https://i.ibb.co/Yt9pMD4/2023-02-07-22-14-10-Window.png)

Day 6: 
- A REST API has been built using Node JS and Express.
- The information in the API can be used to display recipe images, ingredient lists, and preparation instructions, etc - API Github link [here](https://github.com/AmmarSyedK/RecipeAPI)
- The API has been deployed using Vercel - Link [here](https://recipe-api-five.vercel.app/recipes)
- Trying now to GET the data from this API and display all the recipes 

![Day 6](https://i.ibb.co/3zXC8T9/image.png)

Day 7:
- The data from the API has been successfully called
- Each item from the API is now displayed in the home menu
- The next day will be the adding of a Search Bar to dynamically search for recipes

![Day 7](https://i.ibb.co/jZWfC7n/image.png)