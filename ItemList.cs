using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;
using System.Linq;

public class ItemList
{
    public bool CheckSectionForItem(string section, string item)
    {
        if (itemsInSections.TryGetValue(section, out var itemsInSection))
        {
            return itemsInSection.Contains(item);
        }

        return false;
    }

    public List<string> sections = new List<string>
    {
        "Section1",
        "Section2",
        "Section3",
        "Section4"
    };

    public static Dictionary<string, List<string>> itemsInSections = new Dictionary<
        string,
        List<string>
    >
    {
        {
            "Section1",
            new List<string>
            {
                "luncheon meat",
                "hot chili sauce",
                "sweet chili sauce",
                "oyster sauce",
                "vinegar",
                "curry paste",
                "soy sauce",
                "sesame oil",
                "beancurd",
                "curry sauce",
                "bambooshoot",
                "noodles",
                "rice stick",
                "misua",
                "imported drinks",
                "pocky",
                "shabu sauce",
                "nori",
                "milk tea",
                "dried kelp",
                "unagi",
                "curry",
                "special snacks",
                "almond",
                "soju",
                "fruit drink",
                "crackers",
                "korean sauce",
                "korean condiments",
                "ramen",
                "kimchi",
                "milk",
                "seaweed",
                "mushrooms",
                "corned beef",
                "canned ham",
                "canned berries",
                "canned tomatoes",
                "canned carrots",
                "salsa",
                "pasta sauce",
                "lasagna",
                "beans",
                "apple cider",
                "spaghetti",
                "rigatoni",
                "pasta",
                "fusilli",
                "macaroni",
                "honey",
                "blueberry jam",
                "salad dressing",
                "bbq sauce",
                "sesame",
                "strawberry jam",
                "nutella",
                "mayonnaise",
                "macaroni cheese",
                "cookie mix",
                "coffee",
                "tea",
                "iced tea",
                "tamarind",
                "peanuts",
                "cookies",
                "cookie sticks",
                "wafers",
                "pretzels",
                "cookie chips",
                "cheese berry pie",
                "choco pie",
                "popcorn",
                "potato strings",
                "potato chips",
                "fruit juice",
                "gums",
                "jellies",
                "marshmallows",
                "candies",
                "chocolate",
                "biscuits",
                "chips",
                "bread stick",
                "special potato chips",
                "junk food",
                "snacks",
                "chicharon",
                "banana chips",
                "polvoron",
                "local snacks",
                "piaya",
                "otap",
                "rosquillos",
                "dried mangoes",
                "special oatmeals",
                "cakewich",
                "wafer sticks",
                "chocolate cake bar",
                "oatmeal",
                "yogurt juice",
                "cocoa powder",
                "cheese cake",
                "powdered milk drink",
                "flakes",
                "instant coffee",
                "instant noodles",
                "ketchup",
                "spaghetti sauce",
                "canned tuna",
                "corn chip",
                "rubbing alcohol",
                "conditioner",
                "toothpaste",
                "toothbrush",
                "powder",
                "shampoo",
                "soap",
                "cotton buds",
                "napkin",
                "disinfectant",
                "tissue",
                "powdered detergent",
                "dishwashing liquid and paste",
                "cleaner",
                "disinfectant spray",
                "wine",
                "liquor",
                "donut",
                "battery",
            }
        },
        {
            "Section2",
            new List<string>
            {
                "diaper",
                "cigarette",
                "dustpan",
                "dustbin",
                "hanger",
                "mosquito net",
                "slippers",
                "rag",
                "pot holder",
                "toilet brush",
                "body lotion",
                "body wash",
                "shave",
                "body cream",
                "moisturizer",
                "facial wash",
                "deodorant",
                "hair styling wax",
                "men shampoo",
                "mouth wash",
                "toothpaste",
                "toothbrush",
                "beauty soap",
                "whitening lotion",
                "cologne",
                "women cologne",
                "baby wipes",
                "baby powder",
                "rejuvenating serum",
                "whitening soap",
                "cream",
                "baby cologne",
                "vitamins",
                "baby wash",
                "shampoo",
                "hair conditioner",
                "soap and body wash",
                "massage oil",
                "pain relief oil",
                "hair freshener",
                "feminine care",
                "pantyliner",
                "menstrual pads",
                "liquid soap",
                "soap",
                "q tips",
                "cotton buds",
                "microwavable plastic containers",
                "aluminum foil",
                "wax paper",
                "bathroom tissue",
                "facial tissue",
                "paper tray",
                "plastic spoon and fork",
                "skewers",
                "aluminum tray",
                "plastic cups",
                "paper cups",
                "plastic plates",
                "paper plates",
                "toilet papers",
                "kitchen towel",
                "bleach",
                "all purpose cleaner",
                "pet food",
                "rodent bait",
                "car sweetener",
                "air freshener",
                "pet shampoo",
                "pet accessories",
                "litter",
                "air purifier",
                "insect killer",
                "spray",
                "floor wax",
                "trash bags",
                "conditioner",
                "dishwashing liquid",
                "fabric conditioner",
                "sponge",
                "floor cleaner",
                "bleach",
                "general purpose cleaner",
                "fabric conditioner",
                "brooms",
                "scrubs",
                "brushes",
                "liquid washing",
                "liquid detergent",
                "powdered detergent",
                "detox powder",
                "tissue",
                "milk for kids",
                "mixed vegetable and soya",
            }
        },
        {
            "Section3",
            new List<string>
            {
                "hazelnut with cocoa spread",
                "cheese block",
                "quickmelt cheese",
                "margarine",
                "mayonnaise",
                "thousand island dressing",
                "caesar dressing",
                "chicken spread",
                "sandwich spread",
                "tuna spread",
                "cheese spread",
                "cream cheese spread",
                "cheddar spread",
                "peanut butter",
                "tikoy",
                "cay-cay",
                "hopia",
                "cream roll",
                "wheat sesame",
                "cinnamon",
                "muffin",
                "brownies",
                "chocolate cake bar",
                "vanilla cake bar",
                "butter toasted bread",
                "toasted bread",
                "white bread",
                "puto cheese",
                "pandesal",
                "sliced bread",
                "thick slice bread",
                "chiffon choco",
                "mamon",
                "chinese steamed bun",
                "raisin load",
                "wheat crd oat",
                "wheat rld oats",
                "chocolate cake sandwich",
                "instant coffee",
                "decaf coffee",
                "original instant coffee",
                "classic decaf coffee",
                "roasted coffee",
                "turmeric corn coffee",
                "corn coffee",
                "multi grain drink mix",
                "coffee mix",
                "creamy blend coffee",
                "italian roast coffee",
                "white coffee mix",
                "brown coffee mix",
                "creamy white coffee",
                "caramel latte mix",
                "black roast coffee",
                "mocha latte",
                "japanese rich drink",
                "yogurt drink with mango",
                "yogurt drink with strawberry",
                "yogurt drink with mixed fruits",
                "caramel flavored milk tea",
                "chocolate flavored milk tea",
                "winter melon flavored milk tea",
                "chocolate soy milk drink",
                "soy milk drink",
                "green tea latte drink",
                "chocolate milk drink",
                "turmeric ginger powdered drink",
                "chocolate tablets",
                "ready made chocolate beverage",
                "milo",
                "almond milk",
                "soya milk",
                "skimmed milk",
                "low fat milk",
                "soy drink milk",
                "soy milk drink oat flavor",
                "soy milk drink strawberry flavor",
                "low sugar milk",
                "fresh milk",
                "vanilla flavored oat mix",
                "chocolate flavored oat mix",
                "strawberry and yogurt granola",
                "berry special granola",
                "whole grain oats",
                "fruits and nuts oats",
                "quickcook oatmeal",
                "breakfast cereal",
                "whole grain oat and wheat cereal",
                "prune juice",
                "sweetened rice cereal",
                "unsweetened chocolate drink",
                "strawberry milk drink for adult",
                "chocolate milk drink for adult",
                "powdered milk drink for pregnant",
                "powdered milk drink for adult",
                "powdered milk drink",
                "powdered chocolate milk drink",
                "sugar free oatmeal",
                "cornflakes cereal",
                "pineapple juice tea drink",
                "green tea drink",
                "apple green tea drink",
                "sports drink citrus flavor",
                "sports drink tropical fruit",
                "sports drink lime flavor",
                "sports drink grapes flavor",
                "lime juice",
                "sparkling softdrinks",
                "carbonated drinks",
                "blended juice drinks",
                "peach drink",
                "root beer",
                "mountain dew",
                "pepsi",
                "cola",
                "grapes drink",
                "royal",
                "sprite",
                "coke",
                "yogurt flavored drink with nata de coco",
                "mango juice drink",
                "orange juice drink",
                "pineapple juice drink",
                "apple juice drink",
                "citrus drink",
                "mango drink concentrate",
                "four season juice drink",
                "sweetened mango puree",
                "apple grape juice",
                "ion supply juice drink",
                "bottled water",
                "sparkling water",
                "apple juice",
                "cranberry juice",
                "apple flavored drink",
                "orange drink",
                "pineapple drink",
                "powdered juice drink",
                "canned softdrink",
                "powdered fruit flavored drinks",
                "no sugar pineapple drink",
                "low calorie beer",
                "gin",
                "beer",
                "flavored beer",
                "canned beer",
                "soju",
                "light gin",
                "vodka",
                "margarita",
                "tequila",
                "spirit drink",
                "whiskey",
                "sparkling wine",
                "red wine",
                "oyster sauce",
                "soy sauce",
                "vinegar",
                "liquid seasoning",
                "tocino mix",
                "marinade mix",
                "seasoning mix",
                "vegetable oil",
                "tabasco sauce",
                "all-purpose flour",
                "corn starch",
                "jelly powder",
                "pancake syrup",
                "hotcake mix",
                "pancake",
                "palm oil",
                "hot sauce",
                "ketchup",
                "tomato sauce",
                "pasta sauce",
                "meat sauce",
                "carbonara",
                "pasta",
                "lasagna",
                "macaroni",
                "spaghetti pack",
                "corned beef",
                "noodles",
                "beef loaf",
                "meat loaf",
                "luncheon meat",
                "chicken flakes",
                "sausage",
                "pork and beans",
                "liver spread",
                "tuna mayo spread",
                "canned tuna",
                "bagoong",
                "bangus in olive oil",
                "sardines in olive oil",
                "sardines",
                "salted black beans",
                "green peas",
                "olives",
                "canned corn",
                "canned mushroom",
                "sweatened condensed milk",
                "milk cream",
                "evaporated creamer",
                "coffee jelly",
                "macapuno",
                "sweatened thick creamer",
                "all purpose cream",
                "canned pineapple",
                "mixed fruit",
                "tropical fruit cocktail",
                "lychees",
                "mandarin oranges",
                "cup noodles",
                "instant noodles",
                "canton",
                "misua",
                "bihon",
                "palabok",
                "odong",
                "sotanghon",
                "soya oil",
                "canola oil",
                "coconut oil",
                "olive oil",
                "basil",
                "batter mix",
                "bread crumbs",
                "sampalok mix",
                "broth cube",
                "seasoning granules",
            }
        },
        {
            "Section4",
            new List<string>
            {
                "meat",
                "chicken",
                "egg",
                "fish",
                "patty",
                "quekiam",
                "squid balls",
                "chorizo",
                "tocino",
                "ham",
                "grind meat",
                "dried fish",
                "sack of rice",
                "corn grits",
                "brown rice",
                "umami seasoning",
                "salt",
                "sugar",
                "white pepper",
                "cayenne pepper",
                "cajun seasoning",
                "basil leaves",
                "garlic pack",
                "cloves",
                "chili powder",
                "black pepper",
                "celery powder",
                "thyme leaves",
                "cumin",
                "icecream",
                "squash",
                "ginger",
                "garlic",
                "onion",
                "potato",
                "eggplant",
                "bell pepper",
                "tomato",
                "chayote",
                "okra",
                "burdock",
                "coconut",
                "charcoal",
                "red onion",
                "camote",
                "cucumber",
                "chicken sandwich",
                "roasted garlic",
                "beef",
                "broccoli bowl",
                "frozen squid",
                "frozen bangus",
                "fish balls",
                "crab sticks",
                "beef siomai frozen",
                "pastry wrappers",
                "pizza crust",
                "molo wrapper",
                "fries",
                "dumpling fries",
                "cheese sticks",
                "beef ribeye",
                "tocino",
                "longganisa",
                "ham",
                "lumpia wrapper",
                "burger patties",
                "bacon",
                "beef tapa",
                "chicken cutlet",
                "shrimp",
                "hotdog",
                "tacchino",
                "gouda",
                "mozzarella",
                "parmesan",
                "cheese",
                "white cheese",
                "dairy cream",
                "butter",
                "fresh milk",
                "water",
                "juice drink",
                "root beer",
                "carbonated drink",
                "sports drink",
                "refreshment drink",
                "kimchi",
                "kimchi sauce",
                "lumpia wrapper",
                "pickled mango",
                "ampalaya",
                "broccoli",
                "okra",
                "radish",
                "bell pepper",
                "kale",
                "lettuce",
                "basil",
                "alugbate",
                "hot pepper",
                "eggplant",
                "string beans",
                "french beans",
                "bok choi",
                "green lemon",
                "zucchini",
                "salad",
                "coriander",
                "sugarbeets",
                "celery",
                "cabbage",
                "chicharon",
                "yansoy",
                "taugi",
                "cauliflower",
                "sword pepper",
                "pechay",
                "tamarind",
                "avocado",
                "kiwi",
                "pineapple slice",
                "blueberries",
                "grapes",
                "oranges",
                "apples",
                "ponkan",
                "pears",
                "watermelon",
                "lemon",
                "kiat-kiat",
                "green apples",
                "yogurt milk drink",
                "yogurt juice",
                "salad area",
                "banana",
                "dragon fruit",
                "sweet golden melon",
                "pineapple",
                "avocado",
                "guava",
                "mangosteen",
                "durian",
                "papaya",
            }
        },
    };

    //ItemCoordinates1 ======================================================================================
    //=======================================================================================================
    public static Dictionary<string, List<Vector3>> itemCoordinates1 = new Dictionary<
        string,
        List<Vector3>
    >
    {
        {
            "luncheon meat",
            new List<Vector3>
            {
                new Vector3(32, 38, 2),
                new Vector3(34, 38, 2),
                new Vector3(37, 38, 2),
                new Vector3(37, 37, 2),
                new Vector3(37, 36, 2),
                new Vector3(47, 38, 2),
                new Vector3(49, 38, 2)
            }
        },
        {
            "hot chili sauce",
            new List<Vector3> { new Vector3(32, 38, 2) }
        },
        {
            "sweet chili sauce",
            new List<Vector3> { new Vector3(32, 37, 2) }
        },
        {
            "oyster sauce",
            new List<Vector3> { new Vector3(32, 38, 2), new Vector3(32, 37, 2) }
        },
        {
            "vinegar",
            new List<Vector3>
            {
                new Vector3(32, 36, 2),
                new Vector3(32, 35, 2),
                new Vector3(37, 33, 2)
            }
        },
        {
            "curry paste",
            new List<Vector3> { new Vector3(32, 36, 2), new Vector3(32, 35, 2) }
        },
        {
            "soy sauce",
            new List<Vector3>
            {
                new Vector3(32, 36, 2),
                new Vector3(32, 35, 2),
                new Vector3(37, 33, 2)
            }
        },
        {
            "sesame oil",
            new List<Vector3> { new Vector3(32, 34, 2) }
        },
        {
            "beancurd",
            new List<Vector3> { new Vector3(32, 33, 2) }
        },
        {
            "curry sauce",
            new List<Vector3> { new Vector3(32, 33, 2) }
        },
        {
            "bambooshoot",
            new List<Vector3> { new Vector3(32, 31, 2) }
        },
        {
            "noodles",
            new List<Vector3>
            {
                new Vector3(32, 30, 2),
                new Vector3(32, 18, 2),
                new Vector3(34, 35, 2),
                new Vector3(34, 34, 2)
            }
        },
        {
            "rice stick",
            new List<Vector3> { new Vector3(32, 28, 2) }
        },
        {
            "misua",
            new List<Vector3> { new Vector3(32, 27, 2) }
        },
        {
            "imported drinks",
            new List<Vector3> { new Vector3(32, 25, 2) }
        },
        {
            "pocky",
            new List<Vector3> { new Vector3(32, 24, 2) }
        },
        {
            "shabu sauce",
            new List<Vector3> { new Vector3(32, 23, 2) }
        },
        {
            "nori",
            new List<Vector3> { new Vector3(32, 22, 2) }
        },
        {
            "milk tea",
            new List<Vector3> { new Vector3(32, 21, 2) }
        },
        {
            "dried kelp",
            new List<Vector3> { new Vector3(32, 20, 2) }
        },
        {
            "unagi",
            new List<Vector3> { new Vector3(32, 19, 2) }
        },
        {
            "curry",
            new List<Vector3> { new Vector3(32, 19, 2) }
        },
        {
            "special snacks",
            new List<Vector3>
            {
                new Vector3(32, 17, 2),
                new Vector3(34, 17, 2),
                new Vector3(42, 17, 2),
                new Vector3(44, 17, 2)
            }
        },
        {
            "almond",
            new List<Vector3> { new Vector3(37, 37, 2), new Vector3(39, 37, 2) }
        },
        {
            "soju",
            new List<Vector3> { new Vector3(34, 28, 2) }
        },
        {
            "fruit drink",
            new List<Vector3> { new Vector3(34, 36, 2) }
        },
        {
            "crackers",
            new List<Vector3>
            {
                new Vector3(34, 36, 2),
                new Vector3(34, 26, 2),
                new Vector3(34, 25, 2),
                new Vector3(44, 30, 2),
                new Vector3(44, 29, 2),
                new Vector3(44, 28, 2),
                new Vector3(44, 27, 2),
                new Vector3(44, 26, 2),
                new Vector3(44, 25, 2),
                new Vector3(44, 24, 2),
                new Vector3(44, 23, 2),
                new Vector3(44, 22, 2),
                new Vector3(44, 21, 2),
                new Vector3(44, 20, 2),
                new Vector3(44, 19, 2),
                new Vector3(44, 18, 2)
            }
        },
        {
            "korean sauce",
            new List<Vector3> { new Vector3(34, 33, 2) }
        },
        {
            "korean condiments",
            new List<Vector3> { new Vector3(34, 32, 2), new Vector3(34, 30, 2) }
        },
        {
            "ramen",
            new List<Vector3>
            {
                new Vector3(34, 31, 2),
                new Vector3(32, 26, 2),
                new Vector3(34, 18, 2),
                new Vector3(34, 24, 2),
                new Vector3(34, 23, 2),
                new Vector3(34, 22, 2),
                new Vector3(34, 21, 2),
                new Vector3(34, 20, 2),
                new Vector3(34, 19, 2)
            }
        },
        {
            "kimchi",
            new List<Vector3> { new Vector3(34, 31, 2) }
        },
        {
            "milk",
            new List<Vector3>
            {
                new Vector3(34, 28, 2),
                new Vector3(27, 13, 2),
                new Vector3(28, 13, 2),
                new Vector3(72, 15, 2),
                new Vector3(72, 13, 2),
                new Vector3(72, 12, 2),
                new Vector3(72, 11, 2),
                new Vector3(72, 10, 2)
            }
        },
        {
            "seaweed",
            new List<Vector3> { new Vector3(34, 27, 2) }
        },
        {
            "mushrooms",
            new List<Vector3> { new Vector3(37, 38, 2), new Vector3(32, 32, 2) }
        },
        {
            "corned beef",
            new List<Vector3>
            {
                new Vector3(37, 38, 2),
                new Vector3(37, 37, 2),
                new Vector3(26, 27, 2)
            }
        },
        {
            "canned ham",
            new List<Vector3> { new Vector3(37, 36, 2) }
        },
        {
            "canned berries",
            new List<Vector3> { new Vector3(37, 35, 2) }
        },
        {
            "canned tomatoes",
            new List<Vector3>
            {
                new Vector3(37, 35, 2),
                new Vector3(39, 38, 2),
                new Vector3(37, 38, 2)
            }
        },
        {
            "canned carrots",
            new List<Vector3> { new Vector3(37, 35, 2) }
        },
        {
            "salsa",
            new List<Vector3> { new Vector3(37, 34, 2) }
        },
        {
            "pasta sauce",
            new List<Vector3> { new Vector3(37, 34, 2) }
        },
        {
            "lasagna",
            new List<Vector3> { new Vector3(37, 33, 2) }
        },
        {
            "beans",
            new List<Vector3> { new Vector3(37, 33, 2) }
        },
        {
            "apple cider",
            new List<Vector3> { new Vector3(37, 33, 2) }
        },
        {
            "spaghetti",
            new List<Vector3> { new Vector3(37, 32, 2) }
        },
        {
            "rigatoni",
            new List<Vector3> { new Vector3(37, 32, 2) }
        },
        {
            "pasta",
            new List<Vector3> { new Vector3(37, 32, 2) }
        },
        {
            "fusilli",
            new List<Vector3> { new Vector3(37, 32, 2) }
        },
        {
            "macaroni",
            new List<Vector3> { new Vector3(37, 31, 2) }
        },
        {
            "honey",
            new List<Vector3> { new Vector3(37, 31, 2) }
        },
        {
            "blueberry jam",
            new List<Vector3> { new Vector3(37, 30, 2), new Vector3(37, 28, 2) }
        },
        {
            "salad dressing",
            new List<Vector3> { new Vector3(37, 30, 2), new Vector3(37, 28, 2) }
        },
        {
            "bbq sauce",
            new List<Vector3> { new Vector3(37, 30, 2), new Vector3(37, 28, 2) }
        },
        {
            "sesame",
            new List<Vector3> { new Vector3(37, 30, 2), new Vector3(37, 28, 2) }
        },
        {
            "strawberry jam",
            new List<Vector3> { new Vector3(37, 29, 2) }
        },
        {
            "nutella",
            new List<Vector3> { new Vector3(37, 29, 2) }
        },
        {
            "mayonnaise",
            new List<Vector3> { new Vector3(37, 29, 2), new Vector3(37, 27, 2) }
        },
        {
            "macaroni cheese",
            new List<Vector3> { new Vector3(37, 26, 2) }
        },
        {
            "cookie mix",
            new List<Vector3> { new Vector3(37, 26, 2) }
        },
        {
            "coffee",
            new List<Vector3>
            {
                new Vector3(37, 25, 2),
                new Vector3(37, 24, 2),
                new Vector3(37, 23, 2)
            }
        },
        {
            "tea",
            new List<Vector3>
            {
                new Vector3(37, 22, 2),
                new Vector3(37, 21, 2),
                new Vector3(37, 20, 2)
            }
        },
        {
            "iced tea",
            new List<Vector3> { new Vector3(37, 19, 2), new Vector3(37, 18, 2) }
        },
        {
            "tamarind",
            new List<Vector3> { new Vector3(39, 38, 2) }
        },
        {
            "peanuts",
            new List<Vector3> { new Vector3(39, 36, 2) }
        },
        {
            "cookies",
            new List<Vector3>
            {
                new Vector3(39, 35, 2),
                new Vector3(39, 30, 2),
                new Vector3(39, 29, 2),
                new Vector3(39, 28, 2),
                new Vector3(44, 38, 2),
                new Vector3(47, 24, 2),
                new Vector3(47, 23, 2),
                new Vector3(47, 22, 2),
                new Vector3(47, 21, 2),
                new Vector3(47, 20, 2)
            }
        },
        {
            "cookie sticks",
            new List<Vector3> { new Vector3(39, 34, 2) }
        },
        {
            "wafers",
            new List<Vector3>
            {
                new Vector3(39, 33, 2),
                new Vector3(44, 37, 2),
                new Vector3(44, 34, 2),
                new Vector3(44, 33, 2),
                new Vector3(47, 38, 2),
                new Vector3(47, 37, 2),
                new Vector3(47, 36, 2),
                new Vector3(47, 35, 2),
                new Vector3(47, 34, 2),
                new Vector3(47, 33, 2),
                new Vector3(47, 32, 2)
            }
        },
        {
            "pretzels",
            new List<Vector3>
            {
                new Vector3(39, 32, 2),
                new Vector3(47, 26, 2),
                new Vector3(47, 25, 2),
                new Vector3(47, 24, 2)
            }
        },
        //s1.2
        {
            "cookie chips",
            new List<Vector3> { new Vector3(39, 31, 2) }
        },
        {
            "cheese berry pie",
            new List<Vector3> { new Vector3(39, 28, 2) }
        },
        {
            "choco pie",
            new List<Vector3> { new Vector3(39, 27, 2) }
        },
        {
            "popcorn",
            new List<Vector3> { new Vector3(39, 26, 2), new Vector3(39, 25, 2) }
        },
        {
            "potato strings",
            new List<Vector3> { new Vector3(39, 23, 2), new Vector3(39, 24, 2) }
        },
        {
            "potato chips",
            new List<Vector3> { new Vector3(39, 22, 2), new Vector3(39, 21, 2) }
        },
        {
            "fruit juice",
            new List<Vector3> { new Vector3(42, 38, 2), new Vector3(44, 38, 2) }
        },
        {
            "gums",
            new List<Vector3> { new Vector3(42, 38, 2) }
        },
        {
            "jellies",
            new List<Vector3> { new Vector3(42, 37, 2) }
        },
        {
            "marshmallows",
            new List<Vector3> { new Vector3(42, 36, 2), new Vector3(42, 35, 2) }
        },
        {
            "candies",
            new List<Vector3>
            {
                new Vector3(42, 34, 2),
                new Vector3(42, 33, 2),
                new Vector3(42, 32, 2),
                new Vector3(42, 31, 2),
                new Vector3(42, 30, 2),
                new Vector3(42, 29, 2),
                new Vector3(42, 28, 2)
            }
        },
        {
            "chocolate",
            new List<Vector3>
            {
                new Vector3(42, 27, 2),
                new Vector3(42, 26, 2),
                new Vector3(42, 25, 2),
                new Vector3(42, 24, 2),
                new Vector3(42, 23, 2),
                new Vector3(42, 22, 2),
                new Vector3(42, 21, 2),
                new Vector3(42, 20, 2),
                new Vector3(42, 19, 2),
                new Vector3(42, 18, 2),
                new Vector3(37, 17, 2),
                new Vector3(39, 20, 2),
                new Vector3(39, 19, 2),
                new Vector3(39, 18, 2),
                new Vector3(39, 17, 2)
            }
        },
        {
            "biscuits",
            new List<Vector3>
            {
                new Vector3(44, 36, 2),
                new Vector3(44, 35, 2),
                new Vector3(44, 32, 2),
                new Vector3(44, 31, 2),
                new Vector3(47, 19, 2),
                new Vector3(47, 18, 2),
                new Vector3(32, 13, 2),
                new Vector3(32, 13, 2),
                new Vector3(32, 13, 2),
                new Vector3(34, 13, 2),
                new Vector3(34, 13, 2),
                new Vector3(34, 13, 2),
                new Vector3(39, 26, 2),
                new Vector3(26, 18, 2),
                new Vector3(26, 22, 2),
            }
        },
        {
            "chips",
            new List<Vector3>
            {
                new Vector3(47, 31, 2),
                new Vector3(47, 30, 2),
                new Vector3(47, 28, 2),
                new Vector3(26, 21, 2),
                new Vector3(27, 21, 2),
                new Vector3(28, 21, 2),
                new Vector3(25, 26, 2)
            }
        },
        {
            "bread stick",
            new List<Vector3> { new Vector3(47, 27, 2) }
        },
        {
            "special potato chips",
            new List<Vector3> { new Vector3(47, 17, 2), new Vector3(49, 17, 2) }
        },
        {
            "junk food",
            new List<Vector3>
            {
                new Vector3(49, 38, 2),
                new Vector3(49, 36, 2),
                new Vector3(49, 34, 2),
                new Vector3(49, 32, 2),
                new Vector3(49, 30, 2),
                new Vector3(49, 27, 2),
                new Vector3(49, 25, 2),
                new Vector3(49, 23, 2),
                new Vector3(49, 21, 2),
                new Vector3(49, 19, 2),
                new Vector3(53, 38, 2),
                new Vector3(53, 36, 2),
                new Vector3(53, 34, 2),
                new Vector3(53, 32, 2),
                new Vector3(53, 30, 2),
                new Vector3(53, 28, 2),
                new Vector3(53, 26, 2),
                new Vector3(53, 24, 2),  
                new Vector3(53, 22, 2),        
                new Vector3(53, 20, 2),
          
            }
        },
        {
            "snacks",
            new List<Vector3>
            {
                new Vector3(53, 38, 2),
                new Vector3(55, 38, 2),
                new Vector3(42, 14, 2)
            }
        },
        {
            "chicharon",
            new List<Vector3> { new Vector3(55, 38, 2) }
        },
        {
            "banana chips",
            new List<Vector3>
            {
                new Vector3(55, 37, 2),
                new Vector3(55, 34, 2),
                new Vector3(55, 33, 2),
                new Vector3(55, 32, 2)
            }
        },
        {
            "polvoron",
            new List<Vector3> { new Vector3(55, 36, 2) }
        },
        {
            "local snacks",
            new List<Vector3> { new Vector3(55, 35, 2) }
        },
        {
            "piaya",
            new List<Vector3> { new Vector3(55, 31, 2), new Vector3(55, 30, 2) }
        },
        {
            "otap",
            new List<Vector3> { new Vector3(55, 29, 2), new Vector3(55, 27, 2) }
        },
        {
            "rosquillos",
            new List<Vector3>
            {
                new Vector3(55, 28, 2),
                new Vector3(55, 27, 2),
                new Vector3(55, 26, 2),
                new Vector3(55, 25, 2),
                new Vector3(55, 24, 2),
                new Vector3(55, 23, 2)
            }
        },
        {
            "dried mangoes",
            new List<Vector3>
            {
                new Vector3(55, 22, 2),
                new Vector3(55, 21, 2),
                new Vector3(55, 20, 2),
                new Vector3(55, 19, 2),
                new Vector3(55, 18, 2)
            }
        },
        {
            "special oatmeals",
            new List<Vector3> { new Vector3(55, 17, 2), new Vector3(53, 17, 2) }
        },
        {
            "cakewich",
            new List<Vector3> { new Vector3(27, 14, 2), new Vector3(28, 14, 2) }
        },
        {
            "wafer sticks",
            new List<Vector3> { new Vector3(25, 13, 2), new Vector3(26, 13, 2) }
        },
        {
            "chocolate cake bar",
            new List<Vector3> { new Vector3(25, 14, 2), new Vector3(26, 14, 2) }
        },
        {
            "oatmeal",
            new List<Vector3>
            {
                new Vector3(27, 13, 2),
                new Vector3(28, 13, 2),
                new Vector3(33, 13, 2)
            }
        },
        {
            "yogurt juice",
            new List<Vector3> { new Vector3(27, 18, 2) }
        },
        {
            "cocoa powder",
            new List<Vector3> { new Vector3(26, 18, 2) }
        },
        {
            "cheese cake",
            new List<Vector3> { new Vector3(27, 17, 2) }
        },
        {
            "powdered milk drink",
            new List<Vector3> { new Vector3(25, 18, 2) }
        },
        {
            "flakes",
            new List<Vector3> { new Vector3(28, 17, 2) }
        },
        {
            "instant coffee",
            new List<Vector3>
            {
                new Vector3(32, 17, 2),
                new Vector3(25, 17, 2),
                new Vector3(26, 17, 2)
            }
        },
        {
            "instant noodles",
            new List<Vector3> { new Vector3(25, 27, 2), new Vector3(28, 27, 2) }
        },
        {
            "ketchup",
            new List<Vector3> { new Vector3(27, 25, 2) }
        },
        {
            "spaghetti sauce",
            new List<Vector3> { new Vector3(28, 25, 2) }
        },
        {
            "canned tuna",
            new List<Vector3> { new Vector3(27, 27, 2) }
        },
        {
            "corn chip",
            new List<Vector3> { new Vector3(25, 25, 2) }
        },
        {
            "rubbing alcohol",
            new List<Vector3>
            {
                new Vector3(55, 13, 2),
                new Vector3(26, 30, 2),
                new Vector3(55, 13, 2)
            }
        },
        {
            "conditioner",
            new List<Vector3> { new Vector3(25, 31, 2) }
        },
        {
            "toothpaste",
            new List<Vector3> { new Vector3(27, 30, 2) }
        },
        {
            "toothbrush",
            new List<Vector3> { new Vector3(27, 30, 2) }
        },
        {
            "powder",
            new List<Vector3> { new Vector3(27, 31, 2) }
        },
        {
            "shampoo",
            new List<Vector3> { new Vector3(28, 30, 2), new Vector3(25, 30, 2) }
        },
        {
            "soap",
            new List<Vector3>
            {
                new Vector3(28, 31, 2),
                new Vector3(53, 13, 2),
                new Vector3(54, 13, 2)
            }
        },
        {
            "cotton buds",
            new List<Vector3> { new Vector3(26, 31, 2) }
        },
        {
            "napkin",
            new List<Vector3> { new Vector3(25, 30, 2) }
        },
        //s1.3
        {
            "disinfectant",
            new List<Vector3> { new Vector3(28, 35, 2) }
        },
        {
            "tissue",
            new List<Vector3>
            {
                new Vector3(25, 31, 2),
                new Vector3(25, 30, 2),
                new Vector3(25, 37, 2),
                new Vector3(25, 35, 2),
                new Vector3(54, 14, 2),
                new Vector3(55, 14, 2)
            }
        },
        {
            "powdered detergent",
            new List<Vector3> { new Vector3(27, 35, 2) }
        },
        {
            "dishwashing liquid and paste",
            new List<Vector3> { new Vector3(26, 37, 2), new Vector3(27, 37, 2) }
        },
        {
            "cleaner",
            new List<Vector3> { new Vector3(26, 35, 2) }
        },
        {
            "disinfectant spray",
            new List<Vector3> { new Vector3(28, 37, 2) }
        },
        {
            "wine",
            new List<Vector3>
            {
                new Vector3(40, 14, 2),
                new Vector3(40, 14, 2),
                new Vector3(40, 14, 2)
            }
        },
        {
            "liquor",
            new List<Vector3> { new Vector3(41, 14, 2), new Vector3(41, 14, 2) }
        },
        {
            "donut",
            new List<Vector3> { new Vector3(47, 13, 2), new Vector3(48, 13, 2) }
        },
        {
            "battery",
            new List<Vector3> { new Vector3(53, 14, 2) }
        },
    };

    //ItemCoordinates2 ======================================================================================
    //=======================================================================================================
    public static Dictionary<string, List<Vector3>> itemCoordinates2 = new Dictionary<
        string,
        List<Vector3>
    >
    {
        {
            "diaper",
            new List<Vector3>
            {
                new Vector3(62, 10, 2),
                new Vector3(68, 34, 2),
                new Vector3(72, 42, 2),
                new Vector3(72, 41, 2),
                new Vector3(72, 40, 2),
                new Vector3(72, 39, 2),
                new Vector3(72, 38, 2),
                new Vector3(72, 37, 2),
                new Vector3(72, 36, 2),
                new Vector3(72, 35, 2),
                new Vector3(72, 34, 2),
                new Vector3(72, 33, 2),
                new Vector3(72, 32, 2),
                new Vector3(72, 31, 2),
                new Vector3(72, 30, 2),
                new Vector3(72, 30, 2)
            }
        },
        {
            "cigarette",
            new List<Vector3> { new Vector3(62, 9, 2) }
        },
        {
            "dustpan",
            new List<Vector3> { new Vector3(63, 10, 2) }
        },
        {
            "dustbin",
            new List<Vector3> { new Vector3(64, 10, 2) }
        },
        {
            "hanger",
            new List<Vector3> { new Vector3(65, 10, 2) }
        },
        {
            "mosquito net",
            new List<Vector3> { new Vector3(66, 10, 2) }
        },
        {
            "slippers",
            new List<Vector3> { new Vector3(67, 10, 2) }
        },
        {
            "rag",
            new List<Vector3> { new Vector3(68, 10, 2) }
        },
        {
            "pot holder",
            new List<Vector3> { new Vector3(69, 10, 2) }
        },
        {
            "toilet brush",
            new List<Vector3> { new Vector3(70, 10, 2) }
        },
        {
            "body lotion",
            new List<Vector3> { new Vector3(62, 15, 2) }
        },
        {
            "body wash",
            new List<Vector3> { new Vector3(62, 14, 2) }
        },
        {
            "shave",
            new List<Vector3> { new Vector3(64, 14, 2) }
        },
        {
            "body cream",
            new List<Vector3> { new Vector3(64, 14, 2) }
        },
        {
            "moisturizer",
            new List<Vector3> { new Vector3(64, 14, 2) }
        },
        {
            "facial wash",
            new List<Vector3> { new Vector3(65, 14, 2) }
        },
        {
            "deodorant",
            new List<Vector3> { new Vector3(66, 14, 2) }
        },
        {
            "hair styling wax",
            new List<Vector3> { new Vector3(67, 14, 2) }
        },
        {
            "men shampoo",
            new List<Vector3> { new Vector3(68, 14, 2) }
        },
        {
            "mouth wash",
            new List<Vector3> { new Vector3(64, 14, 2), new Vector3(65, 14, 2) }
        },
        {
            "toothpaste",
            new List<Vector3> { new Vector3(66, 14, 2), new Vector3(67, 14, 2) }
        },
        {
            "toothbrush",
            new List<Vector3> { new Vector3(68, 14, 2) }
        },
        {
            "beauty soap",
            new List<Vector3> { new Vector3(62, 19, 2) }
        },
        {
            "whitening lotion",
            new List<Vector3> { new Vector3(63, 19, 2), new Vector3(64, 19, 2) }
        },
        {
            "cologne",
            new List<Vector3> { new Vector3(65, 19, 2) }
        },
        {
            "women cologne",
            new List<Vector3> { new Vector3(66, 19, 2) }
        },
        {
            "baby wipes",
            new List<Vector3> { new Vector3(67, 19, 2) }
        },
        {
            "baby powder",
            new List<Vector3> { new Vector3(68, 19, 2), new Vector3(68, 22, 2) }
        },
        {
            "rejuvenating serum",
            new List<Vector3> { new Vector3(62, 19, 2) }
        },
        {
            "whitening soap",
            new List<Vector3> { new Vector3(63, 19, 2), new Vector3(64, 19, 2) }
        },
        {
            "cream",
            new List<Vector3>
            {
                new Vector3(65, 19, 2),
                new Vector3(66, 19, 2),
                new Vector3(67, 19, 2),
                new Vector3(68, 19, 2)
            }
        },
        {
            "baby cologne",
            new List<Vector3> { new Vector3(62, 22, 2) }
        },
        {
            "vitamins",
            new List<Vector3> { new Vector3(62, 22, 2) }
        },
        {
            "baby wash",
            new List<Vector3> { new Vector3(63, 22, 2) }
        },
        {
            "shampoo",
            new List<Vector3>
            {
                new Vector3(64, 22, 2),
                new Vector3(65, 22, 2),
                new Vector3(62, 13, 2),
                new Vector3(62, 38, 2),
                new Vector3(62, 13, 2)
            }
        },
        {
            "hair conditioner",
            new List<Vector3> { new Vector3(66, 22, 2), new Vector3(63, 25, 2) }
        },
        {
            "soap and body wash",
            new List<Vector3> { new Vector3(67, 22, 2), new Vector3(65, 14, 2) }
        },
        {
            "massage oil",
            new List<Vector3> { new Vector3(62, 25, 2) }
        },
        {
            "pain relief oil",
            new List<Vector3> { new Vector3(62, 25, 2) }
        },
        {
            "hair freshener",
            new List<Vector3> { new Vector3(64, 25, 2) }
        },
        {
            "feminine care",
            new List<Vector3> { new Vector3(65, 25, 2) }
        },
        {
            "pantyliner",
            new List<Vector3> { new Vector3(65, 25, 2) }
        },
        {
            "menstrual pads",
            new List<Vector3> { new Vector3(65, 25, 2) }
        },
        {
            "liquid soap",
            new List<Vector3> { new Vector3(66, 25, 2) }
        },
        {
            "soap",
            new List<Vector3> { new Vector3(67, 25, 2) }
        },
        {
            "q tips",
            new List<Vector3> { new Vector3(68, 25, 2) }
        },
        {
            "cotton buds",
            new List<Vector3> { new Vector3(68, 25, 2) }
        },
        {
            "microwavable plastic containers",
            new List<Vector3>
            {
                new Vector3(62, 30, 2),
                new Vector3(62, 29, 2),
                new Vector3(62, 28, 2)
            }
        },
        {
            "aluminum foil",
            new List<Vector3> { new Vector3(64, 29, 2) }
        },
        {
            "wax paper",
            new List<Vector3> { new Vector3(64, 29, 2) }
        },
        {
            "bathroom tissue",
            new List<Vector3> { new Vector3(65, 29, 2) }
        },
        {
            "facial tissue",
            new List<Vector3> { new Vector3(65, 29, 2) }
        },
        {
            "paper tray",
            new List<Vector3> { new Vector3(66, 29, 2) }
        },
        {
            "plastic spoon and fork",
            new List<Vector3> { new Vector3(66, 29, 2) }
        },
        {
            "skewers",
            new List<Vector3> { new Vector3(66, 29, 2) }
        },
        {
            "aluminum tray",
            new List<Vector3> { new Vector3(66, 29, 2) }
        },
        {
            "plastic cups",
            new List<Vector3> { new Vector3(67, 29, 2) }
        },
        {
            "paper cups",
            new List<Vector3> { new Vector3(67, 29, 2) }
        },
        {
            "plastic plates",
            new List<Vector3> { new Vector3(67, 29, 2) }
        },
        {
            "paper plates",
            new List<Vector3> { new Vector3(67, 29, 2) }
        },
        {
            "toilet papers",
            new List<Vector3> { new Vector3(68, 29, 2) }
        },
        {
            "kitchen towel",
            new List<Vector3> { new Vector3(68, 29, 2) }
        },
        {
            "bleach",
            new List<Vector3> { new Vector3(62, 34, 2), new Vector3(66, 38, 2) }
        },
        {
            "all purpose cleaner",
            new List<Vector3> { new Vector3(62, 34, 2) }
        },
        {
            "pet food",
            new List<Vector3> { new Vector3(63, 34, 2) }
        },
        {
            "rodent bait",
            new List<Vector3> { new Vector3(64, 34, 2) }
        },
        {
            "car sweetener",
            new List<Vector3> { new Vector3(64, 34, 2) }
        },
        {
            "air freshener",
            new List<Vector3> { new Vector3(64, 34, 2) }
        },
        {
            "pet shampoo",
            new List<Vector3> { new Vector3(65, 34, 2) }
        },
        {
            "pet accessories",
            new List<Vector3> { new Vector3(65, 34, 2) }
        },
        {
            "litter",
            new List<Vector3> { new Vector3(65, 34, 2) }
        },
        {
            "air purifier",
            new List<Vector3> { new Vector3(66, 34, 2) }
        },
        {
            "insect killer",
            new List<Vector3> { new Vector3(66, 34, 2) }
        },
        {
            "spray",
            new List<Vector3> { new Vector3(66, 34, 2) }
        },
        {
            "floor wax",
            new List<Vector3> { new Vector3(67, 34, 2) }
        },
        {
            "trash bags",
            new List<Vector3> { new Vector3(68, 34, 2) }
        },
        {
            "conditioner",
            new List<Vector3> { new Vector3(63, 38, 2) }
        },
        {
            "dishwashing liquid",
            new List<Vector3> { new Vector3(64, 38, 2) }
        },
        {
            "fabric conditioner",
            new List<Vector3> { new Vector3(65, 38, 2), new Vector3(67, 38, 2) }
        },
        {
            "sponge",
            new List<Vector3> { new Vector3(66, 38, 2) }
        },
        {
            "floor cleaner",
            new List<Vector3> { new Vector3(66, 38, 2) }
        },
        {
            "general purpose cleaner",
            new List<Vector3> { new Vector3(66, 38, 2) }
        },
        {
            "brooms",
            new List<Vector3> { new Vector3(68, 38, 2) }
        },
        {
            "scrubs",
            new List<Vector3> { new Vector3(68, 38, 2) }
        },
        {
            "brushes",
            new List<Vector3> { new Vector3(68, 38, 2) }
        },
        //s2.2
        {
            "liquid washing",
            new List<Vector3> { new Vector3(63, 42, 2) }
        },
        {
            "liquid detergent",
            new List<Vector3> { new Vector3(64, 42, 2) }
        },
        {
            "powdered detergent",
            new List<Vector3>
            {
                new Vector3(65, 42, 2),
                new Vector3(67, 42, 2),
                new Vector3(68, 42, 2)
            }
        },
        {
            "detox powder",
            new List<Vector3> { new Vector3(66, 42, 2) }
        },
        {
            "tissue",
            new List<Vector3>
            {
                new Vector3(72, 28, 2),
                new Vector3(72, 27, 2),
                new Vector3(72, 26, 2),
            }
        },
        {
            "milk for kids",
            new List<Vector3>
            {
                new Vector3(72, 25, 2),
                new Vector3(72, 24, 2),
                new Vector3(72, 23, 2),
                new Vector3(72, 22, 2),
                new Vector3(72, 21, 2),
                new Vector3(72, 20, 2),
                new Vector3(72, 19, 2),
                new Vector3(72, 18, 2)
            }
        },
        {
            "mixed vegetable and soya",
            new List<Vector3> { new Vector3(72, 17, 2), new Vector3(72, 16, 2) }
        },
    };

    //ItemCoordinates3 ======================================================================================
    //=======================================================================================================
    public static Dictionary<string, List<Vector3>> itemCoordinates3 = new Dictionary<
        string,
        List<Vector3>
    >
    {
        {
            "hazelnut with cocoa spread",
            new List<Vector3> { new Vector3(26, 58, 2) }
        },
        {
            "cheese block",
            new List<Vector3> { new Vector3(26, 57, 2) }
        },
        {
            "quickmelt cheese",
            new List<Vector3> { new Vector3(26, 56, 2) }
        },
        {
            "margarine",
            new List<Vector3> { new Vector3(26, 55, 2) }
        },
        {
            "mayonnaise",
            new List<Vector3> { new Vector3(26, 54, 2) }
        },
        {
            "thousand island dressing",
            new List<Vector3> { new Vector3(26, 53, 2) }
        },
        {
            "caesar dressing",
            new List<Vector3> { new Vector3(26, 53, 2) }
        },
        {
            "chicken spread",
            new List<Vector3> { new Vector3(26, 52, 2) }
        },
        {
            "sandwich spread",
            new List<Vector3> { new Vector3(26, 51, 2) }
        },
        {
            "tuna spread",
            new List<Vector3> { new Vector3(26, 50, 2) }
        },
        {
            "cheese spread",
            new List<Vector3> { new Vector3(26, 49, 2) }
        },
        {
            "cream cheese spread",
            new List<Vector3> { new Vector3(26, 48, 2) }
        },
        {
            "cheddar spread",
            new List<Vector3> { new Vector3(26, 47, 2) }
        },
        {
            "peanut butter",
            new List<Vector3> { new Vector3(26, 46, 2) }
        },
        {
            "tikoy",
            new List<Vector3> { new Vector3(26, 45, 2) }
        },
        {
            "cay-cay",
            new List<Vector3> { new Vector3(26, 44, 2) }
        },
        {
            "hopia",
            new List<Vector3> { new Vector3(26, 46, 2) }
        },
        {
            "cream roll",
            new List<Vector3> { new Vector3(26, 45, 2) }
        },
        {
            "wheat sesame",
            new List<Vector3> { new Vector3(26, 44, 2) }
        },
        {
            "cinnamon",
            new List<Vector3> { new Vector3(28, 58, 2) }
        },
        {
            "muffin",
            new List<Vector3> { new Vector3(28, 57, 2) }
        },
        {
            "brownies",
            new List<Vector3> { new Vector3(28, 56, 2) }
        },
        {
            "chocolate cake bar",
            new List<Vector3> { new Vector3(28, 55, 2) }
        },
        {
            "vanilla cake bar",
            new List<Vector3> { new Vector3(28, 54, 2) }
        },
        {
            "butter toasted bread",
            new List<Vector3> { new Vector3(28, 53, 2) }
        },
        {
            "toasted bread",
            new List<Vector3> { new Vector3(28, 52, 2) }
        },
        {
            "white bread",
            new List<Vector3> { new Vector3(28, 51, 2) }
        },
        {
            "puto cheese",
            new List<Vector3> { new Vector3(28, 50, 2) }
        },
        {
            "pandesal",
            new List<Vector3> { new Vector3(28, 49, 2) }
        },
        {
            "sliced bread",
            new List<Vector3> { new Vector3(28, 48, 2) }
        },
        {
            "thick slice bread",
            new List<Vector3> { new Vector3(28, 47, 2) }
        },
        {
            "chiffon choco",
            new List<Vector3> { new Vector3(28, 46, 2) }
        },
        {
            "mamon",
            new List<Vector3> { new Vector3(28, 45, 2) }
        },
        {
            "chinese steamed bun",
            new List<Vector3> { new Vector3(28, 44, 2) }
        },
        {
            "raisin load",
            new List<Vector3> { new Vector3(28, 46, 2) }
        },
        {
            "wheat crd oat",
            new List<Vector3> { new Vector3(28, 45, 2) }
        },
        {
            "wheat rld oats",
            new List<Vector3> { new Vector3(28, 44, 2) }
        },
        {
            "chocolate cake sandwich",
            new List<Vector3> { new Vector3(32, 59, 2) }
        },
        {
            "instant coffee",
            new List<Vector3> { new Vector3(32, 59, 2) }
        },
        {
            "decaf coffee",
            new List<Vector3> { new Vector3(32, 58, 2) }
        },
        {
            "original instant coffee",
            new List<Vector3> { new Vector3(32, 57, 2) }
        },
        {
            "classic decaf coffee",
            new List<Vector3> { new Vector3(32, 56, 2) }
        },
        {
            "roasted coffee",
            new List<Vector3> { new Vector3(32, 55, 2) }
        },
        {
            "turmeric corn coffee",
            new List<Vector3> { new Vector3(32, 54, 2) }
        },
        {
            "corn coffee",
            new List<Vector3> { new Vector3(32, 53, 2) }
        },
        {
            "multi grain drink mix",
            new List<Vector3> { new Vector3(32, 52, 2) }
        },
        {
            "coffee mix",
            new List<Vector3>
            {
                new Vector3(32, 51, 2),
                new Vector3(32, 50, 2),
                new Vector3(32, 49, 2)
            }
        },
        {
            "creamy blend coffee",
            new List<Vector3> { new Vector3(32, 48, 2) }
        },
        {
            "italian roast coffee",
            new List<Vector3> { new Vector3(32, 47, 2) }
        },
        {
            "white coffee mix",
            new List<Vector3> { new Vector3(32, 46, 2) }
        },
        {
            "brown coffee mix",
            new List<Vector3> { new Vector3(32, 45, 2) }
        },
        {
            "creamy white coffee",
            new List<Vector3> { new Vector3(32, 45, 2) }
        },
        {
            "caramel latte mix",
            new List<Vector3> { new Vector3(32, 43, 2) }
        },
        {
            "black roast coffee",
            new List<Vector3> { new Vector3(32, 45, 2) }
        },
        {
            "mocha latte",
            new List<Vector3> { new Vector3(32, 43, 2) }
        },
        {
            "japanese rich drink",
            new List<Vector3> { new Vector3(34, 59, 2) }
        },
        {
            "yogurt drink with mango",
            new List<Vector3> { new Vector3(34, 59, 2) }
        },
        {
            "yogurt drink with strawberry",
            new List<Vector3> { new Vector3(34, 58, 2) }
        },
        {
            "yogurt drink with mixed fruits",
            new List<Vector3> { new Vector3(34, 57, 2) }
        },
        {
            "caramel flavored milk tea",
            new List<Vector3> { new Vector3(34, 56, 2) }
        },
        {
            "chocolate flavored milk tea",
            new List<Vector3> { new Vector3(34, 55, 2) }
        },
        {
            "winter melon flavored milk tea",
            new List<Vector3> { new Vector3(34, 54, 2) }
        },
        {
            "chocolate soy milk drink",
            new List<Vector3> { new Vector3(34, 53, 2) }
        },
        {
            "soy milk drink",
            new List<Vector3> { new Vector3(37, 52, 2), new Vector3(25, 22, 2) }
        },
        {
            "green tea latte drink",
            new List<Vector3> { new Vector3(34, 51, 2) }
        },
        {
            "chocolate milk drink",
            new List<Vector3>
            {
                new Vector3(34, 50, 2),
                new Vector3(34, 49, 2),
                new Vector3(34, 48, 2),
                new Vector3(34, 47, 2),
                new Vector3(34, 46, 2),
                new Vector3(34, 45, 2),
                new Vector3(47, 57, 2)
            }
        },
        {
            "turmeric ginger powdered drink",
            new List<Vector3> { new Vector3(34, 45, 2) }
        },
        {
            "chocolate tablets",
            new List<Vector3> { new Vector3(34, 43, 2) }
        },
        {
            "ready made chocolate beverage",
            new List<Vector3> { new Vector3(34, 45, 2) }
        },
        {
            "milo",
            new List<Vector3> { new Vector3(34, 43, 2) }
        },
        {
            "almond milk",
            new List<Vector3> { new Vector3(37, 59, 2) }
        },
        {
            "soya milk",
            new List<Vector3> { new Vector3(37, 59, 2) }
        },
        {
            "skimmed milk",
            new List<Vector3> { new Vector3(37, 58, 2) }
        },
        {
            "low fat milk",
            new List<Vector3> { new Vector3(37, 57, 2) }
        },
        {
            "soy drink milk",
            new List<Vector3> { new Vector3(37, 56, 2) }
        },
        {
            "soy milk drink oat flavor",
            new List<Vector3> { new Vector3(37, 55, 2) }
        },
        {
            "soy milk drink strawberry flavor",
            new List<Vector3> { new Vector3(37, 54, 2) }
        },
        {
            "low sugar milk",
            new List<Vector3> { new Vector3(37, 53, 2) }
        },
        //s3.2
        {
            "fresh milk",
            new List<Vector3> { new Vector3(37, 52, 2) }
        },
        {
            "vanilla flavored oat mix",
            new List<Vector3> { new Vector3(37, 51, 2) }
        },
        {
            "chocolate flavored oat mix",
            new List<Vector3> { new Vector3(37, 50, 2) }
        },
        {
            "strawberry and yogurt granola",
            new List<Vector3> { new Vector3(37, 49, 2) }
        },
        {
            "berry special granola",
            new List<Vector3> { new Vector3(37, 48, 2) }
        },
        {
            "whole grain oats",
            new List<Vector3> { new Vector3(37, 47, 2) }
        },
        {
            "fruits and nuts oats",
            new List<Vector3> { new Vector3(37, 46, 2) }
        },
        {
            "quickcook oatmeal",
            new List<Vector3> { new Vector3(37, 45, 2) }
        },
        {
            "breakfast cereal",
            new List<Vector3> { new Vector3(37, 44, 2) }
        },
        {
            "whole grain oat and wheat cereal",
            new List<Vector3> { new Vector3(37, 43, 2) }
        },
        {
            "prune juice",
            new List<Vector3> { new Vector3(37, 44, 2) }
        },
        {
            "sweetened rice cereal",
            new List<Vector3> { new Vector3(37, 43, 2) }
        },
        {
            "unsweetened chocolate drink",
            new List<Vector3> { new Vector3(39, 59, 2), new Vector3(28, 18, 2) }
        },
        {
            "strawberry milk drink for adult",
            new List<Vector3> { new Vector3(39, 59, 2) }
        },
        {
            "chocolate milk drink for adult",
            new List<Vector3> { new Vector3(39, 58, 2) }
        },
        {
            "powdered milk drink for pregnant",
            new List<Vector3> { new Vector3(39, 57, 2) }
        },
        {
            "powdered milk drink for adult",
            new List<Vector3>
            {
                new Vector3(39, 56, 2),
                new Vector3(39, 55, 2),
                new Vector3(39, 54, 2),
                new Vector3(39, 53, 2),
                new Vector3(39, 52, 2),
                new Vector3(39, 51, 2),
            }
        },
        {
            "powdered milk drink",
            new List<Vector3>
            {
                new Vector3(39, 50, 2),
                new Vector3(39, 49, 2),
                new Vector3(39, 48, 2),
                new Vector3(39, 47, 2),
                new Vector3(39, 44, 2),
                new Vector3(39, 43, 2)
            }
        },
        {
            "powdered chocolate milk drink",
            new List<Vector3> { new Vector3(39, 46, 2), new Vector3(39, 45, 2) }
        },
        {
            "sugar free oatmeal",
            new List<Vector3> { new Vector3(39, 44, 2) }
        },
        {
            "cornflakes cereal",
            new List<Vector3> { new Vector3(39, 43, 2) }
        },
        {
            "pineapple juice tea drink",
            new List<Vector3> { new Vector3(42, 59, 2) }
        },
        {
            "green tea drink",
            new List<Vector3> { new Vector3(42, 59, 2) }
        },
        {
            "apple green tea drink",
            new List<Vector3> { new Vector3(42, 58, 2) }
        },
        {
            "sports drink citrus flavor",
            new List<Vector3> { new Vector3(42, 57, 2) }
        },
        {
            "sports drink tropical fruit",
            new List<Vector3> { new Vector3(42, 56, 2) }
        },
        {
            "sports drink lime flavor",
            new List<Vector3> { new Vector3(42, 55, 2) }
        },
        {
            "sports drink grapes flavor",
            new List<Vector3> { new Vector3(42, 54, 2) }
        },
        {
            "lime juice",
            new List<Vector3> { new Vector3(42, 53, 2), new Vector3(47, 48, 2) }
        },
        {
            "sparkling softdrinks",
            new List<Vector3> { new Vector3(42, 52, 2) }
        },
        {
            "carbonated drinks",
            new List<Vector3> { new Vector3(42, 51, 2) }
        },
        {
            "blended juice drinks",
            new List<Vector3> { new Vector3(42, 50, 2) }
        },
        {
            "peach drink",
            new List<Vector3> { new Vector3(42, 49, 2) }
        },
        {
            "root beer",
            new List<Vector3> { new Vector3(42, 48, 2) }
        },
        {
            "mountain dew",
            new List<Vector3> { new Vector3(42, 47, 2) }
        },
        {
            "pepsi",
            new List<Vector3> { new Vector3(42, 46, 2) }
        },
        {
            "cola",
            new List<Vector3> { new Vector3(42, 45, 2) }
        },
        {
            "grapes drink",
            new List<Vector3> { new Vector3(42, 44, 2) }
        },
        {
            "royal",
            new List<Vector3> { new Vector3(42, 43, 2) }
        },
        {
            "sprite",
            new List<Vector3> { new Vector3(42, 44, 2) }
        },
        {
            "coke",
            new List<Vector3> { new Vector3(42, 43, 2) }
        },
        {
            "yogurt flavored drink with nata de coco",
            new List<Vector3> { new Vector3(44, 59, 2) }
        },
        {
            "mango juice drink",
            new List<Vector3> { new Vector3(44, 58, 2) }
        },
        {
            "orange juice drink",
            new List<Vector3> { new Vector3(44, 57, 2) }
        },
        {
            "pineapple juice drink",
            new List<Vector3> { new Vector3(44, 56, 2) }
        },
        {
            "apple juice drink",
            new List<Vector3> { new Vector3(44, 55, 2), new Vector3(47, 59, 2) }
        },
        {
            "citrus drink",
            new List<Vector3> { new Vector3(44, 54, 2) }
        },
        {
            "mango drink concentrate",
            new List<Vector3> { new Vector3(44, 53, 2) }
        },
        {
            "four season juice drink",
            new List<Vector3> { new Vector3(44, 52, 2) }
        },
        {
            "sweetened mango puree",
            new List<Vector3> { new Vector3(44, 51, 2) }
        },
        {
            "apple grape juice",
            new List<Vector3> { new Vector3(44, 50, 2) }
        },
        {
            "ion supply juice drink",
            new List<Vector3> { new Vector3(44, 49, 2) }
        },
        {
            "bottled water",
            new List<Vector3>
            {
                new Vector3(44, 48, 2),
                new Vector3(44, 47, 2),
                new Vector3(44, 46, 2),
                new Vector3(44, 45, 2),
                new Vector3(44, 44, 2)
            }
        },
        {
            "sparkling water",
            new List<Vector3> { new Vector3(44, 43, 2) }
        },
        {
            "apple juice",
            new List<Vector3> { new Vector3(44, 44, 2) }
        },
        {
            "cranberry juice",
            new List<Vector3> { new Vector3(44, 43, 2) }
        },
        {
            "apple flavored drink",
            new List<Vector3> { new Vector3(47, 59, 2) }
        },
        {
            "orange drink",
            new List<Vector3> { new Vector3(47, 58, 2) }
        },
        {
            "pineapple drink",
            new List<Vector3> { new Vector3(47, 56, 2) }
        },
        {
            "powdered juice drink",
            new List<Vector3> { new Vector3(47, 55, 2) }
        },
        {
            "canned softdrink",
            new List<Vector3> { new Vector3(47, 54, 2) }
        },
        {
            "powdered fruit flavored drinks",
            new List<Vector3>
            {
                new Vector3(47, 53, 2),
                new Vector3(47, 52, 2),
                new Vector3(47, 51, 2)
            }
        },
        {
            "no sugar pineapple drink",
            new List<Vector3> { new Vector3(47, 50, 2) }
        },
        {
            "low calorie beer",
            new List<Vector3> { new Vector3(47, 49, 2) }
        },
        {
            "gin",
            new List<Vector3>
            {
                new Vector3(47, 47, 2),
                new Vector3(49, 59, 2),
                new Vector3(49, 58, 2)
            }
        },
        {
            "beer",
            new List<Vector3> { new Vector3(47, 46, 2), new Vector3(47, 45, 2) }
        },
        {
            "flavored beer",
            new List<Vector3> { new Vector3(47, 43, 2) }
        },
        {
            "canned beer",
            new List<Vector3> { new Vector3(47, 45, 2) }
        },
        {
            "soju",
            new List<Vector3>
            {
                new Vector3(47, 43, 2),
                new Vector3(49, 57, 2),
                new Vector3(49, 56, 2)
            }
        },
        {
            "light gin",
            new List<Vector3> { new Vector3(49, 55, 2) }
        },
        {
            "vodka",
            new List<Vector3> { new Vector3(49, 54, 2) }
        },
        {
            "margarita",
            new List<Vector3> { new Vector3(49, 53, 2) }
        },
        {
            "tequila",
            new List<Vector3>
            {
                new Vector3(49, 52, 2),
                new Vector3(49, 51, 2),
                new Vector3(49, 50, 2)
            }
        },
        //s3.3
        {
            "spirit drink",
            new List<Vector3>
            {
                new Vector3(49, 49, 2),
                new Vector3(49, 48, 2),
                new Vector3(49, 47, 2),
                new Vector3(49, 46, 2)
            }
        },
        {
            "whiskey",
            new List<Vector3> { new Vector3(49, 45, 2) }
        },
        {
            "sparkling wine",
            new List<Vector3> { new Vector3(49, 45, 2) }
        },
        {
            "red wine",
            new List<Vector3> { new Vector3(49, 43, 2) }
        },
        {
            "oyster sauce",
            new List<Vector3> { new Vector3(37, 72, 2), new Vector3(39, 72, 2) }
        },
        {
            "soy sauce",
            new List<Vector3>
            {
                new Vector3(37, 71, 2),
                new Vector3(37, 70, 2),
                new Vector3(26, 27, 2)
            }
        },
        {
            "vinegar",
            new List<Vector3> { new Vector3(37, 69, 2), new Vector3(37, 68, 2) }
        },
        {
            "liquid seasoning",
            new List<Vector3> { new Vector3(37, 67, 2) }
        },
        {
            "tocino mix",
            new List<Vector3> { new Vector3(37, 66, 2) }
        },
        {
            "marinade mix",
            new List<Vector3> { new Vector3(37, 65, 2) }
        },
        {
            "seasoning mix",
            new List<Vector3> { new Vector3(37, 64, 2) }
        },
        {
            "vegetable oil",
            new List<Vector3>
            {
                new Vector3(37, 63, 2),
                new Vector3(34, 74, 2),
                new Vector3(46, 75, 2)
            }
        },
        {
            "tabasco sauce",
            new List<Vector3> { new Vector3(39, 71, 2) }
        },
        {
            "all-purpose flour",
            new List<Vector3> { new Vector3(39, 70, 2), new Vector3(39, 69, 2) }
        },
        {
            "corn starch",
            new List<Vector3> { new Vector3(39, 68, 2) }
        },
        {
            "jelly powder",
            new List<Vector3> { new Vector3(39, 67, 2) }
        },
        {
            "pancake syrup",
            new List<Vector3> { new Vector3(39, 66, 2) }
        },
        {
            "hotcake mix",
            new List<Vector3> { new Vector3(39, 65, 2) }
        },
        {
            "pancake",
            new List<Vector3> { new Vector3(39, 64, 2) }
        },
        {
            "palm oil",
            new List<Vector3>
            {
                new Vector3(39, 63, 2),
                new Vector3(34, 74, 2),
                new Vector3(50, 75, 2)
            }
        },
        {
            "hot sauce",
            new List<Vector3> { new Vector3(42, 72, 2) }
        },
        {
            "ketchup",
            new List<Vector3> { new Vector3(42, 71, 2) }
        },
        {
            "tomato sauce",
            new List<Vector3> { new Vector3(42, 70, 2) }
        },
        {
            "pasta sauce",
            new List<Vector3> { new Vector3(42, 69, 2) }
        },
        {
            "meat sauce",
            new List<Vector3> { new Vector3(42, 68, 2) }
        },
        {
            "carbonara",
            new List<Vector3> { new Vector3(42, 67, 2) }
        },
        {
            "pasta",
            new List<Vector3> { new Vector3(42, 66, 2) }
        },
        {
            "lasagna",
            new List<Vector3> { new Vector3(42, 65, 2) }
        },
        {
            "macaroni",
            new List<Vector3> { new Vector3(42, 64, 2) }
        },
        {
            "spaghetti pack",
            new List<Vector3> { new Vector3(42, 63, 2), new Vector3(44, 63, 2) }
        },
        {
            "corned beef",
            new List<Vector3>
            {
                new Vector3(44, 71, 2),
                new Vector3(44, 70, 2),
                new Vector3(47, 71, 2),
                new Vector3(47, 70, 2)
            }
        },
        {
            "noodles",
            new List<Vector3>
            {
                new Vector3(44, 72, 2),
                new Vector3(47, 72, 2),
                new Vector3(48, 75, 2),
                new Vector3(51, 75, 2),
                new Vector3(48, 75, 2)
            }
        },
        {
            "beef loaf",
            new List<Vector3>
            {
                new Vector3(44, 69, 2),
                new Vector3(44, 68, 2),
                new Vector3(49, 63, 2)
            }
        },
        {
            "meat loaf",
            new List<Vector3> { new Vector3(44, 67, 2), new Vector3(44, 66, 2) }
        },
        {
            "luncheon meat",
            new List<Vector3> { new Vector3(44, 65, 2), new Vector3(44, 64, 2) }
        },
        {
            "chicken flakes",
            new List<Vector3> { new Vector3(47, 69, 2) }
        },
        {
            "sausage",
            new List<Vector3> { new Vector3(47, 68, 2), new Vector3(47, 67, 2) }
        },
        {
            "pork and beans",
            new List<Vector3> { new Vector3(47, 66, 2) }
        },
        {
            "liver spread",
            new List<Vector3> { new Vector3(47, 65, 2) }
        },
        {
            "tuna mayo spread",
            new List<Vector3> { new Vector3(47, 64, 2) }
        },
        {
            "canned tuna",
            new List<Vector3>
            {
                new Vector3(47, 63, 2),
                new Vector3(53, 72, 2),
                new Vector3(53, 71, 2),
                new Vector3(53, 70, 2),
                new Vector3(53, 69, 2)
            }
        },
        {
            "bagoong",
            new List<Vector3>
            {
                new Vector3(49, 72, 2),
                new Vector3(49, 71, 2),
                new Vector3(49, 70, 2)
            }
        },
        {
            "bangus in olive oil",
            new List<Vector3> { new Vector3(49, 69, 2) }
        },
        {
            "sardines in olive oil",
            new List<Vector3> { new Vector3(49, 68, 2) }
        },
        {
            "sardines",
            new List<Vector3>
            {
                new Vector3(49, 67, 2),
                new Vector3(49, 66, 2),
                new Vector3(49, 65, 2),
                new Vector3(49, 64, 2)
            }
        },
        {
            "salted black beans",
            new List<Vector3> { new Vector3(53, 69, 2) }
        },
        {
            "green peas",
            new List<Vector3> { new Vector3(53, 68, 2) }
        },
        {
            "olives",
            new List<Vector3> { new Vector3(53, 68, 2) }
        },
        {
            "canned corn",
            new List<Vector3> { new Vector3(53, 67, 2) }
        },
        {
            "canned mushroom",
            new List<Vector3> { new Vector3(53, 66, 2) }
        },
        {
            "sweatened condensed milk",
            new List<Vector3>
            {
                new Vector3(53, 65, 2),
                new Vector3(53, 64, 2),
                new Vector3(53, 63, 2),
                new Vector3(53, 62, 2)
            }
        },
        {
            "milk cream",
            new List<Vector3> { new Vector3(53, 62, 2) }
        },
        {
            "evaporated creamer",
            new List<Vector3> { new Vector3(53, 61, 2) }
        },
        {
            "coffee jelly",
            new List<Vector3> { new Vector3(53, 60, 2) }
        },
        {
            "macapuno",
            new List<Vector3> { new Vector3(53, 59, 2) }
        },
        {
            "sweatened thick creamer",
            new List<Vector3> { new Vector3(53, 58, 2), new Vector3(53, 57, 2) }
        },
        {
            "all purpose cream",
            new List<Vector3> { new Vector3(53, 56, 2) }
        },
        {
            "canned pineapple",
            new List<Vector3> { new Vector3(53, 55, 2) }
        },
        {
            "mixed fruit",
            new List<Vector3> { new Vector3(53, 54, 2), new Vector3(53, 53, 2) }
        },
        {
            "tropical fruit cocktail",
            new List<Vector3> { new Vector3(53, 52, 2), new Vector3(53, 51, 2) }
        },
        {
            "lychees",
            new List<Vector3> { new Vector3(53, 50, 2) }
        },
        {
            "mandarin oranges",
            new List<Vector3> { new Vector3(53, 50, 2) }
        },
        {
            "cup noodles",
            new List<Vector3>
            {
                new Vector3(36, 75, 2),
                new Vector3(37, 75, 2),
                new Vector3(38, 75, 2)
            }
        },
        {
            "instant noodles",
            new List<Vector3>
            {
                new Vector3(39, 75, 2),
                new Vector3(40, 75, 2),
                new Vector3(41, 75, 2),
                new Vector3(42, 75, 2),
                new Vector3(43, 75, 2)
            }
        },
        {
            "canton",
            new List<Vector3> { new Vector3(44, 75, 2) }
        },
        {
            "misua",
            new List<Vector3> { new Vector3(45, 75, 2) }
        },
        {
            "bihon",
            new List<Vector3>
            {
                new Vector3(46, 75, 2),
                new Vector3(47, 75, 2),
                new Vector3(48, 75, 2),
                new Vector3(49, 75, 2)
            }
        },
        {
            "palabok",
            new List<Vector3> { new Vector3(48, 75, 2) }
        },
        {
            "odong",
            new List<Vector3> { new Vector3(48, 75, 2) }
        },
        {
            "sotanghon",
            new List<Vector3>
            {
                new Vector3(49, 75, 2),
                new Vector3(50, 75, 2),
                new Vector3(51, 75, 2)
            }
        },
        {
            "soya oil",
            new List<Vector3> { new Vector3(34, 74, 2) }
        },
        {
            "canola oil",
            new List<Vector3> { new Vector3(34, 73, 2) }
        },
        {
            "coconut oil",
            new List<Vector3> { new Vector3(34, 72, 2) }
        },
        {
            "olive oil",
            new List<Vector3> { new Vector3(34, 71, 2), new Vector3(34, 70, 2) }
        },
        {
            "basil",
            new List<Vector3> { new Vector3(34, 69, 2) }
        },
        {
            "batter mix",
            new List<Vector3> { new Vector3(34, 68, 2) }
        },
        {
            "bread crumbs",
            new List<Vector3> { new Vector3(34, 67, 2) }
        },
        {
            "sampalok mix",
            new List<Vector3> { new Vector3(34, 66, 2) }
        },
        //s3.4
        {
            "broth cube",
            new List<Vector3> { new Vector3(34, 65, 2) }
        },
        {
            "seasoning granules",
            new List<Vector3> { new Vector3(34, 64, 2) }
        },
    };

    //ItemCoordinates4 ======================================================================================
    //=======================================================================================================
    public static Dictionary<string, List<Vector3>> itemCoordinates4 = new Dictionary<
        string,
        List<Vector3>
    >
    {
        {
            "meat",
            new List<Vector3>
            {
                new Vector3(31, 62, 2),
                new Vector3(30, 62, 2),
                new Vector3(29, 62, 2),
                new Vector3(28, 62, 2),
                new Vector3(27, 62, 2),
                new Vector3(26, 62, 2),
                new Vector3(25, 62, 2),
                new Vector3(24, 62, 2),
                new Vector3(23, 62, 2),
                new Vector3(22, 62, 2)
            }
        },
        {
            "chicken",
            new List<Vector3>
            {
                new Vector3(12, 62, 2),
                new Vector3(13, 62, 2),
                new Vector3(14, 62, 2),
                new Vector3(15, 62, 2),
                new Vector3(16, 62, 2),
                new Vector3(17, 62, 2),
                new Vector3(18, 62, 2),
                new Vector3(19, 62, 2),
                new Vector3(20, 62, 2)
            }
        },
        {
            "egg",
            new List<Vector3>
            {
                new Vector3(4, 59, 2),
                new Vector3(8, 50, 2),
                new Vector3(9, 50, 2),
                new Vector3(10, 50, 2),
                new Vector3(11, 50, 2),
                new Vector3(12, 50, 2),
                new Vector3(13, 50, 2)
            }
        },
        {
            "fish",
            new List<Vector3>
            {
                new Vector3(5, 62, 2),
                new Vector3(6, 62, 2),
                new Vector3(7, 62, 2),
                new Vector3(8, 62, 2)
            }
        },
        {
            "patty",
            new List<Vector3> { new Vector3(17, 59, 2), new Vector3(0, 33, 2) }
        },
        {
            "quekiam",
            new List<Vector3> { new Vector3(17, 59, 2) }
        },
        {
            "squid balls",
            new List<Vector3> { new Vector3(17, 59, 2), new Vector3(0, 52, 2) }
        },
        {
            "chorizo",
            new List<Vector3> { new Vector3(17, 57, 2) }
        },
        {
            "tocino",
            new List<Vector3> { new Vector3(17, 57, 2), new Vector3(0, 40, 2) }
        },
        {
            "ham",
            new List<Vector3> { new Vector3(17, 57, 2), new Vector3(0, 38, 2) }
        },
        {
            "grind meat",
            new List<Vector3> { new Vector3(18, 57, 2), new Vector3(19, 57, 2) }
        },
        {
            "dried fish",
            new List<Vector3>
            {
                new Vector3(8, 52, 2),
                new Vector3(9, 52, 2),
                new Vector3(10, 52, 2)
            }
        },
        {
            "sack of rice",
            new List<Vector3>
            {
                new Vector3(8, 57, 2),
                new Vector3(9, 57, 2),
                new Vector3(10, 57, 2),
                new Vector3(11, 57, 2),
                new Vector3(12, 57, 2),
                new Vector3(8, 58, 2),
                new Vector3(9, 58, 2),
                new Vector3(10, 58, 2),
                new Vector3(11, 58, 2),
                new Vector3(12, 58, 2),
                new Vector3(11, 52, 2),
                new Vector3(12, 52, 2),
                new Vector3(13, 52, 2),
                new Vector3(14, 52, 2)
            }
        },
        {
            "corn grits",
            new List<Vector3> { new Vector3(15, 52, 2), new Vector3(16, 52, 2) }
        },
        {
            "brown rice",
            new List<Vector3> { new Vector3(17, 52, 2), new Vector3(18, 52, 2) }
        },
        {
            "umami seasoning",
            new List<Vector3> { new Vector3(19, 52, 2) }
        },
        {
            "salt",
            new List<Vector3> { new Vector3(20, 52, 2), new Vector3(20, 50, 2) }
        },
        {
            "sugar",
            new List<Vector3> { new Vector3(14, 50, 2), new Vector3(15, 50, 2) }
        },
        {
            "white pepper",
            new List<Vector3> { new Vector3(16, 50, 2), new Vector3(17, 50, 2) }
        },
        {
            "cayenne pepper",
            new List<Vector3> { new Vector3(17, 50, 2), new Vector3(19, 50, 2) }
        },
        {
            "cajun seasoning",
            new List<Vector3> { new Vector3(17, 50, 2) }
        },
        {
            "basil leaves",
            new List<Vector3> { new Vector3(17, 50, 2) }
        },
        {
            "garlic pack",
            new List<Vector3> { new Vector3(17, 50, 2), new Vector3(19, 50, 2) }
        },
        {
            "cloves",
            new List<Vector3> { new Vector3(17, 50, 2) }
        },
        {
            "chili powder",
            new List<Vector3> { new Vector3(17, 50, 2) }
        },
        {
            "black pepper",
            new List<Vector3> { new Vector3(17, 50, 2), new Vector3(18, 50, 2) }
        },
        {
            "celery powder",
            new List<Vector3> { new Vector3(19, 50, 2) }
        },
        {
            "thyme leaves",
            new List<Vector3> { new Vector3(19, 50, 2) }
        },
        {
            "cumin",
            new List<Vector3> { new Vector3(19, 50, 2) }
        },
        {
            "icecream",
            new List<Vector3>
            {
                new Vector3(8, 45, 2),
                new Vector3(10, 45, 2),
                new Vector3(12, 45, 2),
                new Vector3(14, 45, 2),
                new Vector3(16, 45, 2),
                new Vector3(18, 45, 2),
                new Vector3(9, 43, 2),
                new Vector3(11, 43, 2),
                new Vector3(13, 43, 2),
                new Vector3(15, 43, 2),
                new Vector3(17, 43, 2),
                new Vector3(19, 43, 2),
                new Vector3(8, 44, 2),
                new Vector3(19, 44, 2)
            }
        },
        {
            "squash",
            new List<Vector3> { new Vector3(8, 37, 2), new Vector3(19, 35, 2) }
        },
        {
            "ginger",
            new List<Vector3> { new Vector3(9, 37, 2), new Vector3(14, 35, 2) }
        },
        {
            "garlic",
            new List<Vector3> { new Vector3(10, 37, 2), new Vector3(9, 35, 2) }
        },
        {
            "onion",
            new List<Vector3> { new Vector3(11, 37, 2) }
        },
        {
            "potato",
            new List<Vector3> { new Vector3(12, 37, 2), new Vector3(13, 35, 2) }
        },
        {
            "eggplant",
            new List<Vector3>
            {
                new Vector3(13, 37, 2),
                new Vector3(18, 35, 2),
                new Vector3(8, 15, 2)
            }
        },
        {
            "bell pepper",
            new List<Vector3>
            {
                new Vector3(14, 37, 2),
                new Vector3(11, 35, 2),
                new Vector3(7, 15, 2)
            }
        },
        {
            "tomato",
            new List<Vector3> { new Vector3(15, 37, 2), new Vector3(12, 35, 2) }
        },
        {
            "chayote",
            new List<Vector3> { new Vector3(16, 37, 2), new Vector3(16, 35, 2) }
        },
        {
            "okra",
            new List<Vector3> { new Vector3(17, 37, 2), new Vector3(7, 15, 2) }
        },
        {
            "burdock",
            new List<Vector3> { new Vector3(18, 37, 2) }
        },
        {
            "coconut",
            new List<Vector3>
            {
                new Vector3(8, 36, 2),
                new Vector3(19, 37, 2),
                new Vector3(19, 36, 2)
            }
        },
        {
            "charcoal",
            new List<Vector3> { new Vector3(8, 35, 2) }
        },
        {
            "red onion",
            new List<Vector3> { new Vector3(10, 35, 2) }
        },
        {
            "camote",
            new List<Vector3> { new Vector3(15, 35, 2) }
        },
        {
            "cucumber",
            new List<Vector3> { new Vector3(17, 35, 2) }
        },
        {
            "chicken sandwich",
            new List<Vector3> { new Vector3(0, 58, 2) }
        },
        {
            "roasted garlic",
            new List<Vector3> { new Vector3(0, 57, 2) }
        },
        {
            "beef",
            new List<Vector3> { new Vector3(0, 56, 2) }
        },
        {
            "broccoli bowl",
            new List<Vector3> { new Vector3(0, 55, 2) }
        },
        {
            "frozen squid",
            new List<Vector3> { new Vector3(0, 54, 2) }
        },
        {
            "frozen bangus",
            new List<Vector3> { new Vector3(0, 53, 2) }
        },
        {
            "fish balls",
            new List<Vector3> { new Vector3(0, 51, 2) }
        },
        {
            "crab sticks",
            new List<Vector3> { new Vector3(0, 50, 2) }
        },
        {
            "beef siomai frozen",
            new List<Vector3> { new Vector3(0, 49, 2) }
        },
        {
            "pastry wrappers",
            new List<Vector3> { new Vector3(0, 48, 2) }
        },
        {
            "pizza crust",
            new List<Vector3> { new Vector3(0, 47, 2) }
        },
        {
            "molo wrapper",
            new List<Vector3> { new Vector3(0, 46, 2) }
        },
        {
            "fries",
            new List<Vector3> { new Vector3(0, 45, 2), new Vector3(0, 43, 2) }
        },
        {
            "dumpling fries",
            new List<Vector3> { new Vector3(0, 44, 2) }
        },
        {
            "cheese sticks",
            new List<Vector3> { new Vector3(0, 42, 2) }
        },
        {
            "beef ribeye",
            new List<Vector3> { new Vector3(0, 41, 2) }
        },
        {
            "longganisa",
            new List<Vector3> { new Vector3(0, 39, 2) }
        },
        {
            "lumpia wrapper",
            new List<Vector3> { new Vector3(0, 37, 2), new Vector3(6, 15, 2) }
        },
        //s4.2
        {
            "burger patties",
            new List<Vector3> { new Vector3(0, 36, 2) }
        },
        {
            "bacon",
            new List<Vector3> { new Vector3(0, 36, 2) }
        },
        {
            "beef tapa",
            new List<Vector3> { new Vector3(0, 35, 2) }
        },
        {
            "chicken cutlet",
            new List<Vector3> { new Vector3(0, 35, 2) }
        },
        {
            "shrimp",
            new List<Vector3> { new Vector3(0, 34, 2) }
        },
        {
            "hotdog",
            new List<Vector3>
            {
                new Vector3(0, 32, 2),
                new Vector3(0, 31, 2),
                new Vector3(0, 32, 2),
                new Vector3(0, 58, 2),
                new Vector3(0, 59, 2),
                new Vector3(0, 58, 2)
            }
        },
        {
            "tacchino",
            new List<Vector3> { new Vector3(4, 28, 2) }
        },
        {
            "gouda",
            new List<Vector3> { new Vector3(4, 28, 2) }
        },
        {
            "mozzarella",
            new List<Vector3> { new Vector3(4, 27, 2) }
        },
        {
            "parmesan",
            new List<Vector3> { new Vector3(4, 27, 2) }
        },
        {
            "cheese",
            new List<Vector3>
            {
                new Vector3(4, 26, 2),
                new Vector3(4, 22, 2),
                new Vector3(4, 22, 2)
            }
        },
        {
            "white cheese",
            new List<Vector3> { new Vector3(4, 25, 2) }
        },
        {
            "dairy cream",
            new List<Vector3> { new Vector3(4, 24, 2) }
        },
        {
            "butter",
            new List<Vector3> { new Vector3(4, 23, 2) }
        },
        {
            "fresh milk",
            new List<Vector3> { new Vector3(4, 22, 2) }
        },
        {
            "water",
            new List<Vector3> { new Vector3(4, 21, 2) }
        },
        {
            "juice drink",
            new List<Vector3> { new Vector3(4, 20, 2) }
        },
        {
            "root beer",
            new List<Vector3> { new Vector3(4, 19, 2) }
        },
        {
            "carbonated drink",
            new List<Vector3> { new Vector3(4, 18, 2) }
        },
        {
            "sports drink",
            new List<Vector3> { new Vector3(4, 17, 2) }
        },
        {
            "refreshment drink",
            new List<Vector3> { new Vector3(4, 16, 2) }
        },
        {
            "kimchi",
            new List<Vector3> { new Vector3(5, 15, 2) }
        },
        {
            "kimchi sauce",
            new List<Vector3> { new Vector3(5, 15, 2) }
        },
        {
            "pickled mango",
            new List<Vector3> { new Vector3(6, 15, 2) }
        },
        {
            "ampalaya",
            new List<Vector3> { new Vector3(7, 15, 2) }
        },
        {
            "broccoli",
            new List<Vector3> { new Vector3(7, 15, 2) }
        },
        {
            "radish",
            new List<Vector3> { new Vector3(7, 15, 2) }
        },
        {
            "kale",
            new List<Vector3> { new Vector3(7, 15, 2) }
        },
        {
            "lettuce",
            new List<Vector3>
            {
                new Vector3(7, 15, 2),
                new Vector3(9, 15, 2),
                new Vector3(10, 15, 2)
            }
        },
        {
            "basil",
            new List<Vector3> { new Vector3(7, 15, 2) }
        },
        {
            "alugbate",
            new List<Vector3> { new Vector3(7, 15, 2) }
        },
        {
            "hot pepper",
            new List<Vector3> { new Vector3(7, 15, 2) }
        },
        {
            "string beans",
            new List<Vector3> { new Vector3(8, 15, 2) }
        },
        {
            "french beans",
            new List<Vector3> { new Vector3(8, 15, 2) }
        },
        {
            "bok choi",
            new List<Vector3> { new Vector3(8, 15, 2) }
        },
        {
            "green lemon",
            new List<Vector3> { new Vector3(8, 15, 2) }
        },
        {
            "zucchini",
            new List<Vector3> { new Vector3(9, 15, 2) }
        },
        {
            "salad",
            new List<Vector3> { new Vector3(9, 15, 2) }
        },
        {
            "coriander",
            new List<Vector3> { new Vector3(9, 15, 2) }
        },
        {
            "sugarbeets",
            new List<Vector3> { new Vector3(9, 15, 2) }
        },
        {
            "celery",
            new List<Vector3> { new Vector3(10, 15, 2) }
        },
        {
            "cabbage",
            new List<Vector3> { new Vector3(10, 15, 2) }
        },
        {
            "chicharon",
            new List<Vector3> { new Vector3(10, 15, 2) }
        },
        {
            "yansoy",
            new List<Vector3> { new Vector3(10, 15, 2) }
        },
        {
            "taugi",
            new List<Vector3> { new Vector3(11, 15, 2) }
        },
        {
            "cauliflower",
            new List<Vector3> { new Vector3(11, 15, 2) }
        },
        {
            "sword pepper",
            new List<Vector3> { new Vector3(11, 15, 2) }
        },
        {
            "pechay",
            new List<Vector3> { new Vector3(12, 15, 2) }
        },
        {
            "tamarind",
            new List<Vector3> { new Vector3(13, 15, 2) }
        },
        {
            "avocado",
            new List<Vector3> { new Vector3(14, 15, 2), new Vector3(18, 30, 2) }
        },
        {
            "kiwi",
            new List<Vector3> { new Vector3(15, 15, 2) }
        },
        {
            "pineapple slice",
            new List<Vector3> { new Vector3(16, 15, 2) }
        },
        {
            "blueberries",
            new List<Vector3> { new Vector3(17, 15, 2) }
        },
        {
            "grapes",
            new List<Vector3> { new Vector3(18, 15, 2), new Vector3(17, 20, 2) }
        },
        {
            "oranges",
            new List<Vector3>
            {
                new Vector3(9, 20, 2),
                new Vector3(12, 20, 2),
                new Vector3(13, 20, 2),
                new Vector3(10, 18, 2),
                new Vector3(13, 18, 2)
            }
        },
        {
            "apples",
            new List<Vector3>
            {
                new Vector3(10, 20, 2),
                new Vector3(11, 20, 2),
                new Vector3(16, 20, 2),
                new Vector3(12, 18, 2),
                new Vector3(14, 18, 2)
            }
        },
        {
            "ponkan",
            new List<Vector3> { new Vector3(14, 20, 2) }
        },
        {
            "pears",
            new List<Vector3> { new Vector3(15, 20, 2), new Vector3(16, 18, 2) }
        },
        {
            "watermelon",
            new List<Vector3> { new Vector3(18, 20, 2), new Vector3(18, 18, 2) }
        },
        {
            "lemon",
            new List<Vector3> { new Vector3(9, 18, 2), new Vector3(17, 18, 2) }
        },
        {
            "kiat-kiat",
            new List<Vector3> { new Vector3(11, 18, 2) }
        },
        {
            "green apples",
            new List<Vector3> { new Vector3(15, 18, 2) }
        },
        {
            "yogurt milk drink",
            new List<Vector3>
            {
                new Vector3(9, 25, 2),
                new Vector3(10, 25, 2),
                new Vector3(11, 25, 2),
                new Vector3(12, 25, 2),
                new Vector3(13, 25, 2)
            }
        },
        {
            "yogurt juice",
            new List<Vector3>
            {
                new Vector3(9, 24, 2),
                new Vector3(10, 24, 2),
                new Vector3(11, 24, 2),
                new Vector3(12, 24, 2),
                new Vector3(13, 24, 2)
            }
        },
        {
            "salad area",
            new List<Vector3>
            {
                new Vector3(10, 30, 2),
                new Vector3(11, 30, 2),
                new Vector3(12, 30, 2),
                new Vector3(13, 30, 2),
                new Vector3(10, 28, 2),
                new Vector3(11, 28, 2),
                new Vector3(12, 28, 2),
                new Vector3(13, 28, 2),
                new Vector3(13, 29, 2)
            }
        },
        {
            "banana",
            new List<Vector3> { new Vector3(17, 30, 2) }
        },
        {
            "dragon fruit",
            new List<Vector3> { new Vector3(18, 30, 2) }
        },
        {
            "sweet golden melon",
            new List<Vector3> { new Vector3(19, 30, 2) }
        },
        {
            "pineapple",
            new List<Vector3> { new Vector3(17, 29, 2) }
        },
        {
            "guava",
            new List<Vector3> { new Vector3(19, 29, 2) }
        },
        {
            "mangosteen",
            new List<Vector3> { new Vector3(17, 28, 2) }
        },
        {
            "durian",
            new List<Vector3> { new Vector3(18, 28, 2) }
        },
        {
            "papaya",
            new List<Vector3> { new Vector3(19, 28, 2) }
        },
    };

    public static Dictionary<string, List<Vector3>> itemCoordinatesExit = new Dictionary<
        string,
        List<Vector3>
    >
    {
        {
            "exit",
            new List<Vector3>
            {
                new Vector3(23, 3, 2),

            }
        },
    };

    //ItemPlacement1 ========================================================================================
    //=======================================================================================================
    public static Dictionary<string, List<string>> itemPlacement1 = new Dictionary<
        string,
        List<string>
    >
    {
        {
            "luncheon meat",
            new List<string> { "up", "up", "left", "left", "left", "up", "up" }
        },
        {
            "hot chili sauce",
            new List<string> { "left" }
        },
        {
            "sweet chili sauce",
            new List<string> { "left" }
        },
        {
            "oyster sauce",
            new List<string> { "left", "left" }
        },
        {
            "vinegar",
            new List<string> { "left", "left", "left" }
        },
        {
            "curry paste",
            new List<string> { "left", "left" }
        },
        {
            "soy sauce",
            new List<string> { "left", "left", "left" }
        },
        {
            "sesame oil",
            new List<string> { "left" }
        },
        {
            "beancurd",
            new List<string> { "left" }
        },
        {
            "curry sauce",
            new List<string> { "left" }
        },
        {
            "bambooshoot",
            new List<string> { "left" }
        },
        {
            "noodles",
            new List<string> { "left", "left", "right", "right" }
        },
        {
            "rice stick",
            new List<string> { "left" }
        },
        {
            "misua",
            new List<string> { "left" }
        },
        {
            "imported drinks",
            new List<string> { "left" }
        },
        {
            "pocky",
            new List<string> { "left" }
        },
        {
            "shabu sauce",
            new List<string> { "left" }
        },
        {
            "nori",
            new List<string> { "left" }
        },
        {
            "milk tea",
            new List<string> { "left" }
        },
        {
            "dried kelp",
            new List<string> { "left" }
        },
        {
            "unagi",
            new List<string> { "left" }
        },
        {
            "curry",
            new List<string> { "left" }
        },
        {
            "special snacks",
            new List<string> { "down", "down", "down", "down" }
        },
        {
            "almond",
            new List<string> { "right", "right" }
        },
        {
            "soju",
            new List<string> { "right" }
        },
        {
            "fruit drink",
            new List<string> { "right" }
        },
        {
            "crackers",
            new List<string>
            {
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right"
            }
        },
        {
            "korean sauce",
            new List<string> { "right" }
        },
        {
            "korean condiments",
            new List<string> { "right", "right" }
        },
        {
            "ramen",
            new List<string>
            {
                "right",
                "left",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right"
            }
        },
        {
            "kimchi",
            new List<string> { "right" }
        },
        {
            "milk",
            new List<string> { "right", "down", "down", "left", "left", "left", "left", "left" }
        },
        {
            "seaweed",
            new List<string> { "right" }
        },
        {
            "mushrooms",
            new List<string> { "up", "left" }
        },
        {
            "corned beef",
            new List<string> { "left", "left", "up" }
        },
        {
            "canned ham",
            new List<string> { "left" }
        },
        {
            "canned berries",
            new List<string> { "left" }
        },
        {
            "canned tomatoes",
            new List<string> { "left", "up", "up" }
        },
        {
            "canned carrots",
            new List<string> { "left" }
        },
        {
            "salsa",
            new List<string> { "left" }
        },
        {
            "pasta sauce",
            new List<string> { "left" }
        },
        {
            "lasagna",
            new List<string> { "left" }
        },
        {
            "beans",
            new List<string> { "left" }
        },
        {
            "apple cider",
            new List<string> { "left" }
        },
        {
            "spaghetti",
            new List<string> { "left" }
        },
        {
            "rigatoni",
            new List<string> { "left" }
        },
        {
            "pasta",
            new List<string> { "left" }
        },
        {
            "fusilli",
            new List<string> { "left" }
        },
        {
            "macaroni",
            new List<string> { "left" }
        },
        {
            "honey",
            new List<string> { "left" }
        },
        {
            "blueberry jam",
            new List<string> { "left", "left" }
        },
        {
            "salad dressing",
            new List<string> { "left", "left", "left" }
        },
        {
            "bbq sauce",
            new List<string> { "left", "left" }
        },
        {
            "sesame",
            new List<string> { "left", "left" }
        },
        {
            "strawberry jam",
            new List<string> { "left" }
        },
        {
            "nutella",
            new List<string> { "left" }
        },
        {
            "mayonnaise",
            new List<string> { "left", "left" }
        },
        {
            "macaroni cheese",
            new List<string> { "left" }
        },
        {
            "cookie mix",
            new List<string> { "left" }
        },
        {
            "coffee",
            new List<string> { "left", "left", "left" }
        },
        {
            "tea",
            new List<string> { "left", "left", "left" }
        },
        {
            "iced tea",
            new List<string> { "left", "left" }
        },
        {
            "tamarind",
            new List<string> { "right" }
        },
        {
            "peanuts",
            new List<string> { "right" }
        },
        {
            "cookies",
            new List<string>
            {
                "right",
                "right",
                "right",
                "right",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left"
            }
        },
        {
            "cookie sticks",
            new List<string> { "right" }
        },
        {
            "wafers",
            new List<string>
            {
                "right",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left"
            }
        },
        {
            "pretzels",
            new List<string> { "right", "left", "left", "left" }
        },
        //s1.2
        {
            "cookie chips",
            new List<string> { "right" }
        },
        {
            "cheese berry pie",
            new List<string> { "right" }
        },
        {
            "choco pie",
            new List<string> { "right" }
        },
        {
            "popcorn",
            new List<string> { "right", "right" }
        },
        {
            "potato strings",
            new List<string> { "right", "right" }
        },
        {
            "potato chips",
            new List<string> { "right", "right" }
        },
        {
            "fruit juice",
            new List<string> { "up", "up" }
        },
        {
            "gums",
            new List<string> { "left" }
        },
        {
            "jellies",
            new List<string> { "left" }
        },
        {
            "marshmallows",
            new List<string> { "left", "left" }
        },
        {
            "candies",
            new List<string> { "left", "left", "left", "left", "left", "left", "left" }
        },
        {
            "chocolate",
            new List<string>
            {
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "down",
                "right",
                "right",
                "right",
                "down"
            }
        },
        {
            "biscuits",
            new List<string>
            {
                "right",
                "right",
                "right",
                "right",
                "left",
                "left",
                "up",
                "down",
                "left",
                "up",
                "down",
                "right",
                "right",
                "up",
                "up",
                "down"
            }
        },
        {
            "chips",
            new List<string> { "left", "left", "left", "down", "down", "down", "left" }
        },
        {
            "bread stick",
            new List<string> { "left" }
        },
        {
            "special potato chips",
            new List<string> { "down", "down" }
        },
        {
            "junk food",
            new List<string>
            {
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "right",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
           
            }
        },
        {
            "snacks",
            new List<string> { "up", "up", "up", "right", "down" }
        },
        {
            "chicharon",
            new List<string> { "right" }
        },
        {
            "banana chips",
            new List<string> { "right", "right", "right", "right" }
        },
        {
            "polvoron",
            new List<string> { "right" }
        },
        {
            "local snacks",
            new List<string> { "right" }
        },
        {
            "piaya",
            new List<string> { "right", "right" }
        },
        {
            "otap",
            new List<string> { "right", "right" }
        },
        {
            "rosquillos",
            new List<string> { "right", "right", "right", "right", "right", "right" }
        },
        {
            "dried mangoes",
            new List<string> { "right", "right", "right", "right", "right" }
        },
        {
            "special oatmeals",
            new List<string> { "down", "down" }
        },
        {
            "cakewich",
            new List<string> { "up", "up" }
        },
        {
            "wafer sticks",
            new List<string> { "down", "down" }
        },
        {
            "chocolate cake bar",
            new List<string> { "up", "up" }
        },
        {
            "oatmeal",
            new List<string> { "down", "down", "down" }
        },
        {
            "yogurt juice",
            new List<string> { "up" }
        },
        {
            "cocoa powder",
            new List<string> { "up" }
        },
        {
            "cheese cake",
            new List<string> { "down" }
        },
        {
            "powdered milk drink",
            new List<string> { "up" }
        },
        {
            "flakes",
            new List<string> { "down" }
        },
        {
            "instant coffee",
            new List<string> { "down", "down", "down" }
        },
        {
            "instant noodles",
            new List<string> { "up", "up" }
        },
        {
            "ketchup",
            new List<string> { "down" }
        },
        {
            "spaghetti sauce",
            new List<string> { "down" }
        },
        {
            "canned tuna",
            new List<string> { "up" }
        },
        {
            "corn chip",
            new List<string> { "down" }
        },
        {
            "rubbing alcohol",
            new List<string> { "down", "down", "down" }
        },
        {
            "conditioner",
            new List<string> { "up" }
        },
        {
            "toothpaste",
            new List<string> { "down" }
        },
        {
            "toothbrush",
            new List<string> { "down" }
        },
        {
            "powder",
            new List<string> { "up" }
        },
        {
            "shampoo",
            new List<string> { "down", "down" }
        },
        {
            "soap",
            new List<string> { "up", "down", "down" }
        },
        {
            "cotton buds",
            new List<string> { "up" }
        },
        {
            "napkin",
            new List<string> { "down" }
        },
        //s1.3
        {
            "disinfectant",
            new List<string> { "down", "up", "up" }
        },
        {
            "tissue",
            new List<string> { "up", "down", "up", "down", "up", "up" }
        },
        {
            "powdered detergent",
            new List<string> { "down" }
        },
        {
            "dishwashing liquid and paste",
            new List<string> { "up", "up" }
        },
        {
            "cleaner",
            new List<string> { "up" }
        },
        {
            "disinfectant spray",
            new List<string> { "up" }
        },
        {
            "wine",
            new List<string> { "up", "left", "down" }
        },
        {
            "liquor",
            new List<string> { "up", "down" }
        },
        {
            "donut",
            new List<string> { "down", "down" }
        },
        {
            "battery",
            new List<string> { "up" }
        },
    };

    //ItemPlacement2 ========================================================================================
    //=======================================================================================================
    public static Dictionary<string, List<string>> itemPlacement2 = new Dictionary<
        string,
        List<string>
    >
    {
        {
            "diaper",
            new List<string>
            {
                "up",
                "up",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left",
                "left"
            }
        },
        {
            "cigarette",
            new List<string> { "left" }
        },
        {
            "dustpan",
            new List<string> { "up" }
        },
        {
            "dustbin",
            new List<string> { "up" }
        },
        {
            "hanger",
            new List<string> { "up" }
        },
        {
            "mosquito net",
            new List<string> { "up" }
        },
        {
            "slippers",
            new List<string> { "up" }
        },
        {
            "rag",
            new List<string> { "up" }
        },
        {
            "pot holder",
            new List<string> { "up" }
        },
        {
            "toilet brush",
            new List<string> { "up" }
        },
        {
            "body lotion",
            new List<string> { "left" }
        },
        {
            "body wash",
            new List<string> { "left", "up" }
        },
        {
            "shave",
            new List<string> { "up" }
        },
        {
            "body cream",
            new List<string> { "up" }
        },
        {
            "moisturizer",
            new List<string> { "up" }
        },
        {
            "facial wash",
            new List<string> { "up" }
        },
        {
            "deodorant",
            new List<string> { "up" }
        },
        {
            "hair styling wax",
            new List<string> { "up" }
        },
        {
            "men shampoo",
            new List<string> { "up" }
        },
        {
            "mouth wash",
            new List<string> { "down", "down" }
        },
        {
            "toothpaste",
            new List<string> { "down", "down", "down" }
        },
        {
            "toothbrush",
            new List<string> { "down", "down" }
        },
        {
            "beauty soap",
            new List<string> { "down" }
        },
        {
            "whitening lotion",
            new List<string> { "down", "down" }
        },
        {
            "cologne",
            new List<string> { "down" }
        },
        {
            "women cologne",
            new List<string> { "down" }
        },
        {
            "baby wipes",
            new List<string> { "down" }
        },
        {
            "baby powder",
            new List<string> { "down", "up" }
        },
        {
            "rejuvenating serum",
            new List<string> { "up" }
        },
        {
            "whitening soap",
            new List<string> { "up", "up" }
        },
        {
            "cream",
            new List<string> { "up", "up", "up", "up" }
        },
        {
            "baby cologne",
            new List<string> { "up" }
        },
        {
            "vitamins",
            new List<string> { "up" }
        },
        {
            "baby wash",
            new List<string> { "up" }
        },
        {
            "shampoo",
            new List<string> { "up", "up", "right", "down", "left" }
        },
        {
            "hair conditioner",
            new List<string> { "up", "up" }
        },
        {
            "soap and body wash",
            new List<string> {"up", "up" }

        },
        {
            "massage oil",
            new List<string> { "up" }
        },
        {
            "pain relief oil",
            new List<string> { "up" }
        },
        {
            "hair freshener",
            new List<string> { "up" }
        },
        {
            "feminine care",
            new List<string> { "up" }
        },
        {
            "pantyliner",
            new List<string> { "up" }
        },
        {
            "menstrual pads",
            new List<string> { "up" }
        },
        {
            "liquid soap",
            new List<string> { "up" }
        },
        {
            "soap",
            new List<string> { "up" }
        },
        {
            "q tips",
            new List<string> { "up" }
        },
        {
            "cotton buds",
            new List<string> { "up" }
        },
        {
            "microwavable plastic containers",
            new List<string> { "left", "left", "left" }
        },
        {
            "aluminum foil",
            new List<string> { "up" }
        },
        {
            "wax paper",
            new List<string> { "up" }
        },
        {
            "bathroom tissue",
            new List<string> { "up" }
        },
        {
            "facial tissue",
            new List<string> { "up" }
        },
        {
            "paper tray",
            new List<string> { "up" }
        },
        {
            "plastic spoon and fork",
            new List<string> { "up" }
        },
        {
            "skewers",
            new List<string> { "up" }
        },
        {
            "aluminum tray",
            new List<string> { "up" }
        },
        {
            "plastic cups",
            new List<string> { "up" }
        },
        {
            "paper cups",
            new List<string> { "up" }
        },
        {
            "plastic plates",
            new List<string> { "up" }
        },
        {
            "paper plates",
            new List<string> { "up" }
        },
        {
            "toilet papers",
            new List<string> { "up" }
        },
        {
            "kitchen towel",
            new List<string> { "up" }
        },
        {
            "bleach",
            new List<string> { "up", "up" }
        },
        {
            "all purpose cleaner",
            new List<string> { "up" }
        },
        {
            "pet food",
            new List<string> { "up" }
        },
        {
            "rodent bait",
            new List<string> { "up" }
        },
        {
            "car sweetener",
            new List<string> { "up" }
        },
        {
            "air freshener",
            new List<string> { "up" }
        },
        {
            "pet shampoo",
            new List<string> { "up" }
        },
        {
            "pet accessories",
            new List<string> { "up" }
        },
        {
            "litter",
            new List<string> { "up" }
        },
        {
            "air purifier",
            new List<string> { "up" }
        },
        {
            "insect killer",
            new List<string> { "up" }
        },
        {
            "spray",
            new List<string> { "up" }
        },
        {
            "floor wax",
            new List<string> { "up" }
        },
        {
            "trash bags",
            new List<string> { "up" }
        },
        {
            "conditioner",
            new List<string> { "up" }
        },
        {
            "dishwashing liquid",
            new List<string> { "up" }
        },
        {
            "fabric conditioner",
            new List<string> { "up", "up" }
        },
        {
            "sponge",
            new List<string> { "up" }
        },
        {
            "floor cleaner",
            new List<string> { "up" }
        },
        {
            "general purpose cleaner",
            new List<string> { "up" }
        },
        {
            "brooms",
            new List<string> { "up" }
        },
        {
            "scrubs",
            new List<string> { "up" }
        },
        {
            "brushes",
            new List<string> { "up" }
        },
        //s2.2
        {
            "liquid washing",
            new List<string> { "down" }
        },
        {
            "liquid detergent",
            new List<string> { "down" }
        },
        {
            "powdered detergent",
            new List<string> { "down", "down", "down" }
        },
        {
            "detox powder",
            new List<string> { "down" }
        },
        {
            "tissue",
            new List<string> { "left", "left", "left"}
        },
        {
            "milk for kids",
            new List<string> { "left", "left", "left", "left", "left", "left", "left", "left" }
        },
        {
            "mixed vegetable and soya",
            new List<string> { "left", "left" }
        },
    };

    //ItemPlacement3 ========================================================================================
    //=======================================================================================================
    public static Dictionary<string, List<string>> itemPlacement3 = new Dictionary<
        string,
        List<string>
    >
    {
        {
            "hazelnut with cocoa spread",
            new List<string> { "up" }
        },
        {
            "cheese block",
            new List<string> { "left" }
        },
        {
            "quickmelt cheese",
            new List<string> { "left" }
        },
        {
            "margarine",
            new List<string> { "left" }
        },
        {
            "mayonnaise",
            new List<string> { "left" }
        },
        {
            "thousand island dressing",
            new List<string> { "left" }
        },
        {
            "caesar dressing",
            new List<string> { "left" }
        },
        {
            "chicken spread",
            new List<string> { "left" }
        },
        {
            "sandwich spread",
            new List<string> { "left" }
        },
        {
            "tuna spread",
            new List<string> { "left" }
        },
        {
            "cheese spread",
            new List<string> { "left" }
        },
        {
            "cream cheese spread",
            new List<string> { "left" }
        },
        {
            "cheddar spread",
            new List<string> { "left" }
        },
        {
            "peanut butter",
            new List<string> { "left" }
        },
        {
            "tikoy",
            new List<string> { "left" }
        },
        {
            "cay-cay",
            new List<string> { "left" }
        },
        {
            "hopia",
            new List<string> { "left" }
        },
        {
            "cream roll",
            new List<string> { "left" }
        },
        {
            "wheat sesame",
            new List<string> { "down" }
        },
        {
            "cinnamon",
            new List<string> { "up" }
        },
        {
            "muffin",
            new List<string> { "right" }
        },
        {
            "brownies",
            new List<string> { "right" }
        },
        {
            "chocolate cake bar",
            new List<string> { "right" }
        },
        {
            "vanilla cake bar",
            new List<string> { "right" }
        },
        {
            "butter toasted bread",
            new List<string> { "right" }
        },
        {
            "toasted bread",
            new List<string> { "right" }
        },
        {
            "white bread",
            new List<string> { "right" }
        },
        {
            "puto cheese",
            new List<string> { "right" }
        },
        {
            "pandesal",
            new List<string> { "right" }
        },
        {
            "sliced bread",
            new List<string> { "right" }
        },
        {
            "thick slice bread",
            new List<string> { "right" }
        },
        {
            "chiffon choco",
            new List<string> { "right" }
        },
        {
            "mamon",
            new List<string> { "right" }
        },
        {
            "chinese steamed bun",
            new List<string> { "right" }
        },
        {
            "raisin load",
            new List<string> { "right" }
        },
        {
            "wheat crd oat",
            new List<string> { "right" }
        },
        {
            "wheat rld oats",
            new List<string> { "down" }
        },
        {
            "chocolate cake sandwich",
            new List<string> { "up" }
        },
        {
            "instant coffee",
            new List<string> { "left" }
        },
        {
            "decaf coffee",
            new List<string> { "left" }
        },
        {
            "original instant coffee",
            new List<string> { "left" }
        },
        {
            "classic decaf coffee",
            new List<string> { "left" }
        },
        {
            "roasted coffee",
            new List<string> { "left" }
        },
        {
            "turmeric corn coffee",
            new List<string> { "left" }
        },
        {
            "corn coffee",
            new List<string> { "left" }
        },
        {
            "multi grain drink mix",
            new List<string> { "left" }
        },
        {
            "coffee mix",
            new List<string> { "left", "left", "left" }
        },
        {
            "creamy blend coffee",
            new List<string> { "left" }
        },
        {
            "italian roast coffee",
            new List<string> { "left" }
        },
        {
            "white coffee mix",
            new List<string> { "left" }
        },
        {
            "brown coffee mix",
            new List<string> { "left" }
        },
        {
            "creamy white coffee",
            new List<string> { "left" }
        },
        {
            "caramel latte mix",
            new List<string> { "left" }
        },
        {
            "black roast coffee",
            new List<string> { "left" }
        },
        {
            "mocha latte",
            new List<string> { "down" }
        },
        {
            "japanese rich drink",
            new List<string> { "up" }
        },
        {
            "yogurt drink with mango",
            new List<string> { "right" }
        },
        {
            "yogurt drink with strawberry",
            new List<string> { "right" }
        },
        {
            "yogurt drink with mixed fruits",
            new List<string> { "right" }
        },
        {
            "caramel flavored milk tea",
            new List<string> { "right" }
        },
        {
            "chocolate flavored milk tea",
            new List<string> { "right" }
        },
        {
            "winter melon flavored milk tea",
            new List<string> { "right" }
        },
        {
            "chocolate soy milk drink",
            new List<string> { "right" }
        },
        {
            "soy milk drink",
            new List<string> { "left", "up" }
        },
        {
            "green tea latte drink",
            new List<string> { "right" }
        },
        {
            "chocolate milk drink",
            new List<string> { "right", "right", "right", "right", "right", "right", "left" }
        },
        {
            "turmeric ginger powdered drink",
            new List<string> { "right" }
        },
        {
            "chocolate tablets",
            new List<string> { "right" }
        },
        {
            "ready made chocolate beverage",
            new List<string> { "right" }
        },
        {
            "milo",
            new List<string> { "down" }
        },
        {
            "almond milk",
            new List<string> { "up" }
        },
        {
            "soya milk",
            new List<string> { "left" }
        },
        {
            "skimmed milk",
            new List<string> { "left" }
        },
        {
            "low fat milk",
            new List<string> { "left" }
        },
        {
            "soy drink milk",
            new List<string> { "left" }
        },
        {
            "soy milk drink oat flavor",
            new List<string> { "left" }
        },
        {
            "soy milk drink strawberry flavor",
            new List<string> { "left" }
        },
        {
            "low sugar milk",
            new List<string> { "left" }
        },
        //s3.2
        {
            "fresh milk",
            new List<string> { "left" }
        },
        {
            "vanilla flavored oat mix",
            new List<string> { "left" }
        },
        {
            "chocolate flavored oat mix",
            new List<string> { "left" }
        },
        {
            "strawberry and yogurt granola",
            new List<string> { "left" }
        },
        {
            "berry special granola",
            new List<string> { "left" }
        },
        {
            "whole grain oats",
            new List<string> { "left" }
        },
        {
            "fruits and nuts oats",
            new List<string> { "left" }
        },
        {
            "quickcook oatmeal",
            new List<string> { "left" }
        },
        {
            "breakfast cereal",
            new List<string> { "left" }
        },
        {
            "whole grain oat and wheat cereal",
            new List<string> { "left" }
        },
        {
            "prune juice",
            new List<string> { "left" }
        },
        {
            "sweetened rice cereal",
            new List<string> { "down" }
        },
        {
            "unsweetened chocolate drink",
            new List<string> { "right", "up" }
        },
        {
            "strawberry milk drink for adult",
            new List<string> { "right" }
        },
        {
            "chocolate milk drink for adult",
            new List<string> { "right" }
        },
        {
            "powdered milk drink for pregnant",
            new List<string> { "right" }
        },
        {
            "powdered milk drink for adult",
            new List<string> { "right", "right", "right", "right", "right", "right" }
        },
        {
            "powdered milk drink",
            new List<string> { "right", "right", "right", "right", "right", "right" }
        },
        {
            "powdered chocolate milk drink",
            new List<string> { "right", "right" }
        },
        {
            "sugar free oatmeal",
            new List<string> { "right" }
        },
        {
            "cornflakes cereal",
            new List<string> { "down" }
        },
        {
            "pineapple juice tea drink",
            new List<string> { "up" }
        },
        {
            "green tea drink",
            new List<string> { "left" }
        },
        {
            "apple green tea drink",
            new List<string> { "left" }
        },
        {
            "sports drink citrus flavor",
            new List<string> { "left" }
        },
        {
            "sports drink tropical fruit",
            new List<string> { "left" }
        },
        {
            "sports drink lime flavor",
            new List<string> { "left" }
        },
        {
            "sports drink grapes flavor",
            new List<string> { "left" }
        },
        {
            "lime juice",
            new List<string> { "left", "left" }
        },
        {
            "sparkling softdrinks",
            new List<string> { "left" }
        },
        {
            "carbonated drinks",
            new List<string> { "left" }
        },
        {
            "blended juice drinks",
            new List<string> { "left" }
        },
        {
            "peach drink",
            new List<string> { "left" }
        },
        {
            "root beer",
            new List<string> { "left" }
        },
        {
            "mountain dew",
            new List<string> { "left" }
        },
        {
            "pepsi",
            new List<string> { "left" }
        },
        {
            "cola",
            new List<string> { "left" }
        },
        {
            "grapes drink",
            new List<string> { "left" }
        },
        {
            "royal",
            new List<string> { "left" }
        },
        {
            "sprite",
            new List<string> { "left" }
        },
        {
            "coke",
            new List<string> { "down" }
        },
        {
            "yogurt flavored drink with nata de coco",
            new List<string> { "up" }
        },
        {
            "mango juice drink",
            new List<string> { "right" }
        },
        {
            "orange juice drink",
            new List<string> { "right" }
        },
        {
            "pineapple juice drink",
            new List<string> { "right" }
        },
        {
            "apple juice drink",
            new List<string> { "right", "left" }
        },
        {
            "citrus drink",
            new List<string> { "right" }
        },
        {
            "mango drink concentrate",
            new List<string> { "right" }
        },
        {
            "four season juice drink",
            new List<string> { "right" }
        },
        {
            "sweetened mango puree",
            new List<string> { "right" }
        },
        {
            "apple grape juice",
            new List<string> { "right" }
        },
        {
            "ion supply juice drink",
            new List<string> { "right" }
        },
        {
            "bottled water",
            new List<string> { "right", "right", "right", "right", "right" }
        },
        {
            "sparkling water",
            new List<string> { "right" }
        },
        {
            "apple juice",
            new List<string> { "right" }
        },
        {
            "cranberry juice",
            new List<string> { "down" }
        },
        {
            "apple flavored drink",
            new List<string> { "up" }
        },
        {
            "orange drink",
            new List<string> { "left" }
        },
        {
            "pineapple drink",
            new List<string> { "left" }
        },
        {
            "powdered juice drink",
            new List<string> { "left" }
        },
        {
            "canned softdrink",
            new List<string> { "left" }
        },
        {
            "powdered fruit flavored drinks",
            new List<string> { "left", "left", "left" }
        },
        {
            "no sugar pineapple drink",
            new List<string> { "left" }
        },
        {
            "low calorie beer",
            new List<string> { "left" }
        },
        {
            "gin",
            new List<string> { "left", "right", "right" }
        },
        {
            "beer",
            new List<string> { "left", "left" }
        },
        {
            "flavored beer",
            new List<string> { "left" }
        },
        {
            "canned beer",
            new List<string> { "left" }
        },
        {
            "soju",
            new List<string> { "down", "right", "right" }
        },
        {
            "light gin",
            new List<string> { "right" }
        },
        {
            "vodka",
            new List<string> { "right" }
        },
        {
            "margarita",
            new List<string> { "right" }
        },
        {
            "tequila",
            new List<string> { "right", "right", "right" }
        },
        //s3.3
        {
            "spirit drink",
            new List<string> { "right", "right", "right", "right" }
        },
        {
            "whiskey",
            new List<string> { "right" }
        },
        {
            "sparkling wine",
            new List<string> { "right" }
        },
        {
            "red wine",
            new List<string> { "down" }
        },
        {
            "oyster sauce",
            new List<string> { "left", "right" }
        },
        {
            "soy sauce",
            new List<string> { "left", "left", "up" }
        },
        {
            "vinegar",
            new List<string> { "left", "left" }
        },
        {
            "liquid seasoning",
            new List<string> { "left" }
        },
        {
            "tocino mix",
            new List<string> { "left" }
        },
        {
            "marinade mix",
            new List<string> { "left" }
        },
        {
            "seasoning mix",
            new List<string> { "left" }
        },
        {
            "vegetable oil",
            new List<string> { "down", "right", "down" }
        },
        {
            "tabasco sauce",
            new List<string> { "right" }
        },
        {
            "all-purpose flour",
            new List<string> { "right", "right" }
        },
        {
            "corn starch",
            new List<string> { "right" }
        },
        {
            "jelly powder",
            new List<string> { "right" }
        },
        {
            "pancake syrup",
            new List<string> { "right" }
        },
        {
            "hotcake mix",
            new List<string> { "right" }
        },
        {
            "pancake",
            new List<string> { "right" }
        },
        {
            "palm oil",
            new List<string> { "down", "right", "down" }
        },
        {
            "hot sauce",
            new List<string> { "left" }
        },
        {
            "ketchup",
            new List<string> { "left" }
        },
        {
            "tomato sauce",
            new List<string> { "left" }
        },
        {
            "pasta sauce",
            new List<string> { "left" }
        },
        {
            "meat sauce",
            new List<string> { "left" }
        },
        {
            "carbonara",
            new List<string> { "left" }
        },
        {
            "pasta",
            new List<string> { "left" }
        },
        {
            "lasagna",
            new List<string> { "left" }
        },
        {
            "macaroni",
            new List<string> { "left" }
        },
        {
            "spaghetti pack",
            new List<string> { "down", "down" }
        },
        {
            "corned beef",
            new List<string> { "right", "right", "left", "left" }
        },
        {
            "noodles",
            new List<string> { "up", "up", "down", "down", "down" }
        },
        {
            "beef loaf",
            new List<string> { "right", "right", "down" }
        },
        {
            "meat loaf",
            new List<string> { "right", "right" }
        },
        {
            "luncheon meat",
            new List<string> { "right", "right" }
        },
        {
            "chicken flakes",
            new List<string> { "left" }
        },
        {
            "sausage",
            new List<string> { "left", "left" }
        },
        {
            "pork and beans",
            new List<string> { "left" }
        },
        {
            "liver spread",
            new List<string> { "left" }
        },
        {
            "tuna mayo spread",
            new List<string> { "left" }
        },
        {
            "canned tuna",
            new List<string> { "down", "left", "left", "left", "left" }
        },
        {
            "bagoong",
            new List<string> { "right", "right", "right" }
        },
        {
            "bangus in olive oil",
            new List<string> { "right" }
        },
        {
            "sardines in olive oil",
            new List<string> { "right" }
        },
        {
            "sardines",
            new List<string> { "right", "right", "right", "right" }
        },
        {
            "salted black beans",
            new List<string> { "left" }
        },
        {
            "green peas",
            new List<string> { "left" }
        },
        {
            "olives",
            new List<string> { "left" }
        },
        {
            "canned corn",
            new List<string> { "left" }
        },
        {
            "canned mushroom",
            new List<string> { "left" }
        },
        {
            "sweatened condensed milk",
            new List<string> { "left", "left", "left", "left" }
        },
        {
            "milk cream",
            new List<string> { "left" }
        },
        {
            "evaporated creamer",
            new List<string> { "left" }
        },
        {
            "coffee jelly",
            new List<string> { "left" }
        },
        {
            "macapuno",
            new List<string> { "left" }
        },
        {
            "sweatened thick creamer",
            new List<string> { "left", "left" }
        },
        {
            "all purpose cream",
            new List<string> { "left" }
        },
        {
            "canned pineapple",
            new List<string> { "left" }
        },
        {
            "mixed fruit",
            new List<string> { "left", "left" }
        },
        {
            "tropical fruit cocktail",
            new List<string> { "left", "left" }
        },
        {
            "lychees",
            new List<string> { "left" }
        },
        {
            "mandarin oranges",
            new List<string> { "left" }
        },
        {
            "cup noodles",
            new List<string> { "down", "down", "down" }
        },
        {
            "instant noodles",
            new List<string> { "down", "down", "down", "down", "down" }
        },
        {
            "canton",
            new List<string> { "down" }
        },
        {
            "misua",
            new List<string> { "down" }
        },
        {
            "bihon",
            new List<string> { "down", "down", "down", "down" }
        },
        {
            "palabok",
            new List<string> { "down" }
        },
        {
            "odong",
            new List<string> { "down" }
        },
        {
            "sotanghon",
            new List<string> { "down", "down", "down" }
        },
        {
            "soya oil",
            new List<string> { "right" }
        },
        {
            "canola oil",
            new List<string> { "right" }
        },
        {
            "coconut oil",
            new List<string> { "right" }
        },
        {
            "olive oil",
            new List<string> { "right", "right" }
        },
        {
            "basil",
            new List<string> { "right" }
        },
        {
            "batter mix",
            new List<string> { "right" }
        },
        {
            "bread crumbs",
            new List<string> { "right" }
        },
        {
            "sampalok mix",
            new List<string> { "right" }
        },
        //s3.4
        {
            "broth cube",
            new List<string> { "right" }
        },
        {
            "seasoning granules",
            new List<string> { "right" }
        },
    };

    //ItemPlacement4 ========================================================================================
    //=======================================================================================================
    public static Dictionary<string, List<string>> itemPlacement4 = new Dictionary<
        string,
        List<string>
    >
    {
        {
            "meat",
            new List<string>
            {
                "down",
                "down",
                "down",
                "down",
                "down",
                "down",
                "down",
                "down",
                "down",
                "down"
            }
        },
        {
            "chicken",
            new List<string>
            {
                "down",
                "down",
                "down",
                "down",
                "down",
                "down",
                "down",
                "down",
                "down"
            }
        },
        {
            "egg",
            new List<string> { "right", "down", "down", "down", "down", "down", "down" }
        },
        {
            "fish",
            new List<string> { "down", "down", "down", "down" }
        },
        {
            "patty",
            new List<string> { "left", "right" }
        },
        {
            "quekiam",
            new List<string> { "left" }
        },
        {
            "squid balls",
            new List<string> { "left", "right" }
        },
        {
            "chorizo",
            new List<string> { "left" }
        },
        {
            "tocino",
            new List<string> { "down", "right" }
        },
        {
            "ham",
            new List<string> { "left", "right" }
        },
        {
            "grind meat",
            new List<string> { "down", "down" }
        },
        {
            "dried fish",
            new List<string> { "up", "up", "up" }
        },
        {
            "sack of rice",
            new List<string>
            {
                "down",
                "down",
                "down",
                "down",
                "down",
                "up",
                "up",
                "up",
                "up",
                "up",
                "up",
                "up",
                "up",
                "up"
            }
        },
        {
            "corn grits",
            new List<string> { "up", "up" }
        },
        {
            "brown rice",
            new List<string> { "up", "up" }
        },
        {
            "umami seasoning",
            new List<string> { "up" }
        },
        {
            "salt",
            new List<string> { "up", "down" }
        },
        {
            "sugar",
            new List<string> { "down", "down" }
        },
        {
            "white pepper",
            new List<string> { "down", "down" }
        },
        {
            "cayenne pepper",
            new List<string> { "down", "down" }
        },
        {
            "cajun seasoning",
            new List<string> { "down" }
        },
        {
            "basil leaves",
            new List<string> { "down" }
        },
        {
            "garlic pack",
            new List<string> { "down", "down" }
        },
        {
            "cloves",
            new List<string> { "down" }
        },
        {
            "chili powder",
            new List<string> { "down" }
        },
        {
            "black pepper",
            new List<string> { "down", "down" }
        },
        {
            "celery powder",
            new List<string> { "down" }
        },
        {
            "thyme leaves",
            new List<string> { "down" }
        },
        {
            "cumin",
            new List<string> { "down" }
        },
        {
            "icecream",
            new List<string>
            {
                "up",
                "up",
                "up",
                "up",
                "up",
                "up",
                "down",
                "down",
                "down",
                "down",
                "down",
                "down",
                "left",
                "right",
            }
        },
        {
            "squash",
            new List<string> { "up", "down" }
        },
        {
            "ginger",
            new List<string> { "up", "down" }
        },
        {
            "garlic",
            new List<string> { "up", "down" }
        },
        {
            "onion",
            new List<string> { "up" }
        },
        {
            "potato",
            new List<string> { "up", "down" }
        },
        {
            "eggplant",
            new List<string> { "up", "down", "up" }
        },
        {
            "bell pepper",
            new List<string> { "up", "down", "up" }
        },
        {
            "tomato",
            new List<string> { "up", "down" }
        },
        {
            "chayote",
            new List<string> { "up", "down" }
        },
        {
            "okra",
            new List<string> { "up", "up" }
        },
        {
            "burdock",
            new List<string> { "up" }
        },
        {
            "coconut",
            new List<string> { "left", "up", "right" }
        },
        {
            "charcoal",
            new List<string> { "down" }
        },
        {
            "red onion",
            new List<string> { "down" }
        },
        {
            "camote",
            new List<string> { "down" }
        },
        {
            "cucumber",
            new List<string> { "down" }
        },
        {
            "chicken sandwich",
            new List<string> { "right" }
        },
        {
            "roasted garlic",
            new List<string> { "right" }
        },
        {
            "beef",
            new List<string> { "right" }
        },
        {
            "broccoli bowl",
            new List<string> { "right" }
        },
        {
            "frozen squid",
            new List<string> { "right" }
        },
        {
            "frozen bangus",
            new List<string> { "right" }
        },
        {
            "fish balls",
            new List<string> { "right" }
        },
        {
            "crab sticks",
            new List<string> { "right" }
        },
        {
            "beef siomai frozen",
            new List<string> { "right" }
        },
        {
            "pastry wrappers",
            new List<string> { "right" }
        },
        {
            "pizza crust",
            new List<string> { "right" }
        },
        {
            "molo wrapper",
            new List<string> { "right" }
        },
        {
            "fries",
            new List<string> { "right", "right" }
        },
        {
            "dumpling fries",
            new List<string> { "right" }
        },
        {
            "cheese sticks",
            new List<string> { "right" }
        },
        {
            "beef ribeye",
            new List<string> { "right" }
        },
        {
            "longganisa",
            new List<string> { "right" }
        },
        {
            "lumpia wrapper",
            new List<string> { "right", "up" }
        },
        //s4.2
        {
            "burger patties",
            new List<string> { "right" }
        },
        {
            "bacon",
            new List<string> { "right" }
        },
        {
            "beef tapa",
            new List<string> { "right" }
        },
        {
            "chicken cutlet",
            new List<string> { "right" }
        },
        {
            "shrimp",
            new List<string> { "right" }
        },
        {
            "hotdog",
            new List<string> { "right", "right", "right", "left", "right", "right" }
        },
        {
            "tacchino",
            new List<string> { "right" }
        },
        {
            "gouda",
            new List<string> { "right" }
        },
        {
            "mozzarella",
            new List<string> { "right" }
        },
        {
            "parmesan",
            new List<string> { "right" }
        },
        {
            "cheese",
            new List<string> { "right", "right", "right" }
        },
        {
            "white cheese",
            new List<string> { "right" }
        },
        {
            "dairy cream",
            new List<string> { "right" }
        },
        {
            "butter",
            new List<string> { "right" }
        },
        {
            "fresh milk",
            new List<string> { "right" }
        },
        {
            "water",
            new List<string> { "right" }
        },
        {
            "juice drink",
            new List<string> { "right" }
        },
        {
            "root beer",
            new List<string> { "right" }
        },
        {
            "carbonated drink",
            new List<string> { "right" }
        },
        {
            "sports drink",
            new List<string> { "right" }
        },
        {
            "refreshment drink",
            new List<string> { "right" }
        },
        {
            "kimchi",
            new List<string> { "up" }
        },
        {
            "kimchi sauce",
            new List<string> { "up" }
        },
        {
            "pickled mango",
            new List<string> { "up" }
        },
        {
            "ampalaya",
            new List<string> { "up" }
        },
        {
            "broccoli",
            new List<string> { "up" }
        },
        {
            "radish",
            new List<string> { "up" }
        },
        {
            "kale",
            new List<string> { "up" }
        },
        {
            "lettuce",
            new List<string> { "up", "up", "up" }
        },
        {
            "basil",
            new List<string> { "up" }
        },
        {
            "alugbate",
            new List<string> { "up" }
        },
        {
            "hot pepper",
            new List<string> { "up" }
        },
        {
            "string beans",
            new List<string> { "up" }
        },
        {
            "french beans",
            new List<string> { "up" }
        },
        {
            "bok choi",
            new List<string> { "up" }
        },
        {
            "green lemon",
            new List<string> { "up" }
        },
        {
            "zucchini",
            new List<string> { "up" }
        },
        {
            "salad",
            new List<string> { "up" }
        },
        {
            "coriander",
            new List<string> { "up" }
        },
        {
            "sugarbeets",
            new List<string> { "up" }
        },
        {
            "celery",
            new List<string> { "up" }
        },
        {
            "cabbage",
            new List<string> { "up" }
        },
        {
            "chicharon",
            new List<string> { "up" }
        },
        {
            "yansoy",
            new List<string> { "up" }
        },
        {
            "taugi",
            new List<string> { "up" }
        },
        {
            "cauliflower",
            new List<string> { "up" }
        },
        {
            "sword pepper",
            new List<string> { "up" }
        },
        {
            "pechay",
            new List<string> { "up" }
        },
        {
            "tamarind",
            new List<string> { "up" }
        },
        {
            "avocado",
            new List<string> { "up", "up" }
        },
        {
            "kiwi",
            new List<string> { "up" }
        },
        {
            "pineapple slice",
            new List<string> { "up" }
        },
        {
            "blueberries",
            new List<string> { "up" }
        },
        {
            "grapes",
            new List<string> { "up", "up" }
        },
        {
            "oranges",
            new List<string> { "up", "up", "up", "down", "down" }
        },
        {
            "apples",
            new List<string> { "up", "up", "up", "down", "down" }
        },
        {
            "ponkan",
            new List<string> { "up" }
        },
        {
            "pears",
            new List<string> { "up", "down" }
        },
        {
            "watermelon",
            new List<string> { "up", "down" }
        },
        {
            "lemon",
            new List<string> { "down", "down" }
        },
        {
            "kiat-kiat",
            new List<string> { "down" }
        },
        {
            "green apples",
            new List<string> { "down" }
        },
        {
            "yogurt milk drink",
            new List<string> { "up", "up", "up", "up", "up" }
        },
        {
            "yogurt juice",
            new List<string> { "down", "down", "down", "down", "down" }
        },
        {
            "salad area",
            new List<string> { "up", "up", "up", "up", "down", "down", "down", "down", "right" }
        },
        {
            "banana",
            new List<string> { "up" }
        },
        {
            "dragon fruit",
            new List<string> { "up" }
        },
        {
            "sweet golden melon",
            new List<string> { "up" }
        },
        {
            "pineapple",
            new List<string> { "left" }
        },
        {
            "guava",
            new List<string> { "right" }
        },
        {
            "mangosteen",
            new List<string> { "down" }
        },
        {
            "durian",
            new List<string> { "down" }
        },
        {
            "papaya",
            new List<string> { "down" }
        },
    };

    public static Dictionary<string, List<string>> itemPlacementExit = new Dictionary<
      string,
      List<string>
  >
    {
        {
            "exit",
            new List<string> { "up" }
        },
    };
}
