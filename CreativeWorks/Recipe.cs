﻿#region License
// Copyright (c) 2015 1010Tires.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using MXTires.Microdata.Core.Intangible.Enumeration;
using MXTires.Microdata.Core.Intangible.Quantities;
using MXTires.Microdata.Core.Intangible.StructuredValues;
using Newtonsoft.Json;

namespace MXTires.Microdata.Core
{
    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via suitableForDiet. The keywords property can also be used to add more detail.
    /// </summary>
    public class Recipe : CreativeWork
    {
        /// <summary>
        /// Duration - The time it takes to actually cook the dish, in ISO 8601 duration format.
        /// </summary>
        [JsonProperty("cookTime")]
        public Duration CookTime { get; set; }

        /// <summary>
        /// Text - The method of cooking, such as Frying, Steaming, ...
        /// </summary>
        [JsonProperty("cookingMethod")]
        public String CookingMethod { get; set; }

        /// <summary>
        /// NutritionInformation - Nutrition information about the recipe.
        /// </summary>
        [JsonProperty("nutrition")]
        public NutritionInformation Nutrition { get; set; }

        /// <summary>
        /// Duration - The length of time it takes to prepare the recipe, in ISO 8601 duration format.
        /// </summary>
        [JsonProperty("prepTime")]
        public Duration PrepTime { get; set; }

        /// <summary>
        /// Text - The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        [JsonProperty("recipeCategory")]
        public String RecipeCategory { get; set; }

        /// <summary>
        /// Text - The cuisine of the recipe (for example, French or Ethiopian).
        /// </summary>
        [JsonProperty("recipeCuisine")]
        public String RecipeCuisine { get; set; }

        /// <summary>
        /// Text - A single ingredient used in the recipe, e.g. sugar, flour or garlic. Supersedes ingredients.
        /// </summary>
        [JsonProperty("recipeIngredient")]
        public String RecipeIngredient { get; set; }

        /// <summary>
        /// ItemList  or Text - A step or instruction involved in making the recipe.
        /// </summary>
        [JsonProperty("recipeInstructions")]
        public object RecipeInstructions { get; set; }


        /// <summary>
        /// Text - The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        [JsonProperty("recipeYield")]
        public String RecipeYield { get; set; }

        /// <summary>
        /// RestrictedDiet - Indicates a dietary restriction or guideline for which this recipe is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [JsonProperty("suitableForDiet")]
        public RestrictedDiet SuitableForDiet { get; set; }

        /// <summary>
        /// Duration 	The total time it takes to prepare and cook the recipe, in ISO 8601 duration format.
        /// </summary>
        [JsonProperty("totalTime")]
        public Duration TotalTime { get; set; }
    }
}