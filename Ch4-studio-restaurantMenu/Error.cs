﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ch4_studio_restaurantMenu
{
    internal class Error
    {
        public static Dictionary<string, string> errors = new Dictionary<string, string>
        {
            {"notValid","That is not a valid selection. Only 1,2,3,4, or 5 is allowed " },
            {"titleChange", "A Valid Title can NOT be blank" },
            {"fullMenu","Menu is full! You'll need to remove or edit an exiting item" },
            {"itemName","Item Name can NOT be blank" },
            {"itemDescription","Item Description can NOT be blank" },
            {"itemPrice","Item price can NOT be blank, and must be a number" },
            {"itemCategory", "That is not a Valid category selection. Only 1,2, or 3 is allowed" },
            {"newItem", "That is not a Valid category selection. Only 1 or 2 is allowed" },
            {"wtf","HOW the Hell did that get through?" }
        };


                // scraped from  https://gameshows.fandom.com/wiki/The_Weakest_Link/Quotes_%26_Catchphrases 
         public static Dictionary<int, string> code = new Dictionary<int, string>()
         {
            {0, "Who's been anything but Entertainment Tonight?"},
            {1, "Whose education was a very sorry waste of time?"},
            {2, "Is there a village that needs its idiot back?"},
            {3, "Who's falling and can't get up?"},
            {4, "Whose elevator doesn't go to the top floor?"},
            {5, "Whose parachute sadly has failed to open?"},
            {6, "Whose talents are better suited for silent film?"},
            {7, "Who's the dark cloud with no silver lining?"},
            {8, "Who's in need of mental floss?"},
            {9, "Whose brain in that last round sadly expired?"},
            {10, "Who's the rotten tooth that needs to be pulled?"},
            {11, "Who is the alien from the planet incompetence?"},
            {12, "Where does knowledge go to die?"},
            {13, "Whose traffic light is permanently stuck on red?"},
            {14, "Who's one fry short of a Happy Meal?"},
            {15, "Who's one egg short of an omelet?"},
            {16, "Who's one shrimp short of an barbie?"},
            {17, "Who is as useful as an ashtray on a motorbike?"},
            {18, "Who has a brain only a mother could love?"},
            {19, "Who truly deserves the domain name}, ignorant.com?"},
            {20, "Whose IQ test has come back negative?"},
            {21, "Whose brain is illegally parked?"},
            {22, "Whose brain is dead, but their body doesn't know it?"},
            {23, "If ignorance is bliss, who has landed in Heaven?"},
            {24, "Whose head is just hot air?"},
            {25, "Who's several margaritas short of a party?"},
            {26, "Who could fill an encyclopedia with all they do not know?"},
            {27, "So you're a eunuch and a coward, are you?"},
            {28, "Banish the Buffoon!"},
            {29, "Eject the Idiot!"},
            {30, "I urge you, ditch the lean, keep the mean."},
            {31, "Who, alas, has delusions of adequacy?"},
            {32, "If brains were taxed, who'd get a refund?"},
            {33, "Whose brain has failed its medical?"},
            {34, "Who's as useful as a cat-flap on a submarine?"},
            {35, "Whose brain cell must feel very lonely indeed?"},
            {36, "Whose only brain cell has finally died of loneliness?"},
            {37, "You obviously have no knowledge to declare!"},
            {38, "The questions are still very easy. The contestants are still very stupid!"},
            {39, "Who perhaps hasn't really got a grasp of the English language?"},
            {40, "Who would come third in a duel?"},
            {41, "Who is obviously denser than Sherwood Forest?"},
            {42, "Whose intellect is on a diet?"},
            {43, "Who's got varicose brains?"},
            {44, "Who's as useful as a fan heater in the desert?"},
            {45, "Whose head has gone on holiday?"},
            {46, "Who here now would have trouble counting their legs?"},
            {47, "Who's more twit than wit?"},
            {48, "Who put the 'more' into moron?"},
            {49, "Whose wheel is turning}, but the hamster is dead?"},
            {50, "Who's the toothless vampire?"},
            {51, "Is there someone here who has a charisma bypass perhaps?"},
            {52, "Who's turning out to be thicker than a chocolate omelette?"},
            {53, "Who's as much use as a bird with vertigo?"},
            {54, "So, in this era of digital television, who's watching the radio?"},
            {55, "Who thinks Double Gloucester is a tale of two cities?"},
            {56, "Who thinks propaganda is having a good look?"},
            {57, "Which drip has gone down the plughole?"},
            {58, "Who thinks Pluto is a friend of Mickey Mouse?"},
            {59, "Who'd win the Sweet FA Cup?"},
            {60, "Who's as useful as a sauna in the Sahara?"},
            {61, "Who looks as if they need a checkup from the neck up?"},
            {62, "Who's the slug in your salad}, the squashed fly on your windscreen?"},
            {63, "Who maybe has no marbles to lose?"},
            {64, "Whose phone has no dialing tone?"},
            {65, "Who's head and shoulders below the rest?"},
            {66, "Who left their brain on the train?"},
            {67, "Whose hair dye has affected his brain?"},
            {68, "Whose college major was Lunch?"},
            {69, "Who's jaw needs to be wired shut?"},
            {70, "Who's one chair short of a dining set?"},
            {71, "Who's one pancake short from a stack?"},
            {72, "Ditch the ditterer!"},
            {73, "Who makes Tarzan look like a Rhodes scholar?"},
            {74, "Who's brain has sprung a leak?"},
            {75, "Who is a huge embassment to the American Educational System?"},
            {76, "Which of you was home schooled....in an outhouse?"},
            {77, "In this group of comic book heroes...who here is LOSER-Man?"},
            {78, "Whose Brainwaves are waving Bye Bye?"},
            {79, "Who is the loose lid on this salt shaker?"},
            {80, "Who is still waiting for some British lady to ask them some questions?"},
            {81, "Who appears to be hooked on something other than phonics?"},
            {82, "Which one of you must have spent Spring Break in Puerto Estupido?"},
            {83, "Who needs to take two smart pills and call me in the morning?"},
            {84, "Who may not be a loser, but they sure play one on TV?"},
            {85, "On this Rodeo Drive, who is the 99 cent store?"},
            {86, "Whose keys to victory are locked in the car?"},
            {87, "Which one of these brains would be turned down by an organ bank?"},
            {88, "Whose mental elevator only goes down?"},
            {89, "Whose mental bungee cord is about to snap?"},
            {90, "Who's been stood up on their date with Victory?"},
            {91, "Which of you takes a licking and keeps on sticking?"},
            {92, "Which of you should sign up for the witness protection program?"},
            {93, "Who's had a lot of nerve just showing up today?"},
            {94, "Who won't be right back after this commercial message?"},
            {95, "Who regrets wasting the gas to get here?"},
            {96, "Whose rapper name would be Foolio?"},
            {97, "Who's that big, nasty dead bug in your jacuzzi?"},
            {98, "Who has a mirror that says WARNING, Objects in mirror are dumber than they appear?"},
            {99, "Who's making the rest of the team say... (whispering) 'I see dumb people...'?"},
            {100, "Who is as greedy as a baseball player}, but as smart as a baseball bat?"},
            {101, "Who thinks Elon Musk is a cologne?"},
            {102, "Who tried to study for a paternity test?"},
            {103, "Who's rap name could be Lil IQ?"},
            {104, "Whose seasons are Winter}, Spring}, Summer}, and Fail?"},
            {105, "Who's still sending emails through an AOL account?"},
            {106, "Who thought Iron Man was a movie about a dry cleaner?"},
            {107, "Who swims the shallow end of the gene pool?"},
            {108, "Who was indecisive, but now they're not so sure?"},
            {109, "Who thinks 'Veni vidi vici' are Jersey Shore cast members?"},
            {110, "Whose pinkie and brain are both the same size?"},
            {111, "Who thinks Fauci is a type of pasta?"},
            {112, "Who's about to be enlisted in the witless protection program?"},
            {113, "Who thinks Quentin Tarantino is an entrée at Olive Garden?"},
            {114, "Who thinks Halle Berry is a Fro-Yo topping?"},
            {115, "Who thought the bar exam was about making cocktails?"},
            {116, "Who tries to text on a landline?"},
            {117, "Who tried to reduce their carbon footprint by buying smaller shoes?"},
            {118, "Who's still waiting for their family members to yell}, 'Good answer'?"},
            {119, "Who needs Google Maps to find their way to a correct answer?"},
            {120, "Who's still excited that Tom friended them on Myspace?"},
            {121, "Who thinks Tik Tok is a breath mint?"},
            {122, "Whose brain is still on hold with Tech Support?"},
            {123, "Who should've watched the show at least once before playing?"},
            {124, "Who thinks Planet Hollywood is between Mercury and Venus?"},
            {125, "Who's the vegan cheese of this dairy department?"},
            {126, "Who thought this was a really weird episode of 'Hollywood Game Night'?"},
            {127, "Whose smartphone wishes it had a smarter owner?"},
            {128, "Whose IQ test came back negative?"},
            {129, "Who thinks Einstein invented bagels?"},
            {130, "Who thinks a treadmill is a tire factory?"},
            {131, "Whose lightbulb is getting dimmer?"},
            {132, "Who thinks Hump Day is a holiday for camels?"},
            {133, "Whose brain likes to take things slow?"},
            {134, "Whose answers should be labeled as spam?"},
            {135, "Who's the pretzel in this bag of Chex Mix?"},
            {136, "Who went to their florist looking for an Iggy Azela?"},
            {137, "Who is still stuck in traffic even though they work from home?"},
            {138, "Who's fallen{50 percent of being a halfwit?"},
            {139, "Who's brainbox is full of junk mail?"},
            {140, "Who just laid a silent, but deadly brain fart?"},
            {141, "Who's so confused they're hoping to be invited back for Final Jeopardy?"},
            {142, "Who thinks antipasta is a vehement opposition to noodles?"},
            {143, "Who is six eggs short of a half-dozen?"},
            {144, "Who tried to grow a chicken by planting an egg?"},
            {145, "Who thinks Dr. Pepper is their primary care physician?"},
            {146, "Who's been banned from Mensa?"},
            {147, "Who took the SAT thinking it was a sitting contest?"},
            {148, "Who actually named their pet peeve?"},
            {149, "Who's cereal is all luck and no charm?"},
            {150, "Whose the least magical fairy in this forest?"},
            {151, "Who's brain has been buffering since this morning?"},
            {152, "Who's still confused that I am not wearing a tracksuit?"},
            {153, "Who's the Rob of this Kardashian family?"},
            {154, "Who's a member of the Flat Earth society?"},
            {155, "Who wishes they have a lifeline?"},
            {156, "Whose backup plan involved a Nigeria Prince they met on the internet?"},
            {157, "Who's the coal this Christmas stocking?"},
            {158, "Whose parents think they bought the wrong baby home?"},
            {159, "Who should be sitting at the children's table?"},
            {160, "Who thinks Panda Express is a drive-thru pet store?"},
            {161, "Whose nearest exit may be behind me?"},
            {162, "Who thinks Vin Diesel is a fossil fuel?"},
            {163, "Who needs a recipe to make ice water?"},
            {164, "Who needs a recipe to make water?"},
            {165, "Who thinks that Pig Latin was spoken by Roman farm animals?"},
            {166, "Who keeps hoping Velcro sneakers make a comeback?"},
            {167, "Who thinks Pro Bono Was Married to Cher?"},
            {168, "Whose bucket list is literary a list of buckets?"},
            {169, "Who is one fry short of a happy meal?"},
            {170, "Who's riding shotgun on the struggle bus?"},
            {171, "Who's always mentally offline?"},
            {172, "Who thinks a horsefly is half horse}, half fly?"},
            {173, "Who can teach a masterclass in falling?"},
            {174, "Whose the valedictorian of summer school?"},
            {175, "Who tried to think and it smelled like burnt rubber?"},
            {176, "Whose brain filed for divorce?"},
            {177, "Who just here to make everyone else look smart?"},
            {178, "Who thinks deviled eggs are evil?"},
            {179, "Who needs a designated thinker?"},
            {180, "Who brought their F game?"},
            {181, "On a scale of one to ten}, who's zero?"},
            {182, "Who couldn't pass the village idiot test?"},
            {183, "Who is not smarter than a{1st grader?"},
            {184, "Whose mental internet crashed in this round?"},
            {185, "Whose exit is about to raise the average IQ in this room?"},
            {186, "Who didn't need ice cream to have brain freeze?"},
            {187, "Who's sad this will live on the internet forever and ever?"},
            {188, "Whose fifteen minutes of fame is almost up?"},
            {189, "Who's having trouble following what I am saying?"},
            {190, "Whose mind is a terrible thing to waste?"},
            {191, "Whose Bucket List is literally a list of buckets?"},
            {192, "Who is about to be Ghosted by This Show?"},
            {193, "Who tried to put gas in their Tesla?"},
            {194, "Who proving Darwin correct?"},
            {195, "Who just only realized that I am not Anne Robinson?"},
            {196, "Who has a song in their heart and nothing in their brain?"},
            {197, "Who thinks IQ stands for I Quit?"},
            {198, "Who doesn’t have to worry about paying taxes on their winnings?"},
            {199, "Whose high school nickname was not Einstein?"},
            {200, "Who’s the candy corn in this pile of Halloween treats?"},
            {201, "Who’s rap name would be Notorious Slow?"},
            {202, "Who proves why first cousins shouldn’t marry?"},
            {203, "Who’s cardboard cutout should’ve play the game instead?"},
            {204, "Who should not be homeschooling their children?"}
         };
    }
}