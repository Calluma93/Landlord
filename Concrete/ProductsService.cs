using Services.Abstract;
using Services.Exceptions;
using Services.Models.Products;
using Services.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Concrete
{
    public class ProductsService : IProductsService
    {
        private static readonly ImageModel manualIconImage = new ImageModel("Manual Icon", "Shared/download-manual-icon.png");

        private static ProductModel aCheekyPint = new ProductModel(
            new ImageModel("A Cheeky Pint Product Banner", "Banners/header-cheeky.jpg"),
            new ImageModel("A Cheeky Pint HomePage Image", "Home/home-cheeky.jpg"),
            new ImageModel("A Cheeky Pint SupportPage Banner", "Support/support-cheeky.jpg"),
            new ImageModel("A Cheeky Pint Mobile Homepage Image", "Mobile/mobile-cheeky.jpg"),
            "a-cheeky-pint",
            "A Cheeky Pint",
            "Optical Compressor",
            "Compact and high-quality optical compressor",
            new ImageModel[]
            {
                new ImageModel("A Cheeky Pint Pedal Left Perspective", "Products/A-Cheeky-Pint/details-example-1.jpg"),
                new ImageModel("A Cheeky Pint Pedal Top Elevation", "Products/A-Cheeky-Pint/details-example-2.jpg"),
                new ImageModel("A Cheeky Pint Pedal Right Perspective", "Products/A-Cheeky-Pint/details-example-3.jpg"),
                new ImageModel("A Cheeky Pint Pedal Bottom Elevation", "Products/A-Cheeky-Pint/details-example-4.jpg"),
                new ImageModel("A Cheeky Pint Pedal Front Elevation", "Products/A-Cheeky-Pint/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("A CHEEKY PINT . COMPRESSOR PEDAL"),
                new DescriptionModel("Treat your guitar sound to some quality compression with the Landlord FX Cheeky Pint. Enjoy an upgrade in tone, dynamics and sustain. With Landlord FX, there’s always time for just one more!"),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("A cheeky pint after a long shift is just the thing to smooth out your day. Too much is a mistake though, and the same is true for compressor pedals. A little can go a long way, especially a quality compressor like the Landlord FX Cheeky Pint. This unit is optical so uses a light-dependant resistor to offer all the natural ‘lag’ and sustain of a 1960’s-era studio compressor."),
                new ParagraphModel("The Cheeky Pint has two modes, selectable via a mini toggle. HALF PINT brings a healthy, moderate level of compression. FULL PINT edges into your sound for a more fully compressed tone with a little extra bite. You can determine the Level, Sensitivity and overall Tone via control knobs on the front panel. "),
                new ParagraphModel("Find out what a cheeky pint can do for the health of your tone with the Landlord FX Cheeky Pint Compressor.")

            },
            new DownloadLinkModel("SupportPdfs/A-Cheeky-Pint-manual.pdf", manualIconImage),
            new MetaDataModel("Landlord Cheeky Pint Compressor Guitar Pedal | Landlord FX", "The Landlord FX Cheeky Pint is an optical compressor pedal in a compact format with True-Bypass switching.")
        );

        private static ProductModel amberNectar = new ProductModel(
            new ImageModel("Amber Nectar Product Banner", "Banners/header-amber.jpg"),
            new ImageModel("Amber Nectar HomePage Image", "Home/home-amber.jpg"),
            new ImageModel("Amber Nectar SupportPage Banner", "Support/support-amber.jpg"),
            new ImageModel("Amber Nectar Mobile Homepage Image", "Mobile/mobile-amber.jpg"),
            "amber-nectar",
            "Amber Nectar",
            "Dual-Mode Overdrive",
            "Smooth Overdrive Pedal with dual modes, natural tube-like drive and high dynamic sensitivity",
            new ImageModel[]
            {
                new ImageModel("Amber Nectar Pedal Left Perspection", "Products/Amber-Nectar/details-example-1.jpg"),
                new ImageModel("Amber Nectar Pedal Top Elevation", "Products/Amber-Nectar/details-example-2.jpg"),
                new ImageModel("Amber Nectar Pedal Right Perspective", "Products/Amber-Nectar/details-example-3.jpg"),
                new ImageModel("Amber Nectar Pedal Bottom Elevation", "Products/Amber-Nectar/details-example-4.jpg"),
                new ImageModel("Amber Nectar Pedal Front Elevation", "Products/Amber-Nectar/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("AMBER NECTAR . DISTORTION PEDAL"),
                new DescriptionModel("One taste of Landlord FX’s Amber Nectar and you’ll be hooked! This is your new favourite overdrive pedal: with a range of textures, tones and gain levels available, you’ll be able to dial in a taste that is as smooth or as potent as you prefer!"),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("The Landlord FX Amber Nectar Overdrive is designed to give you the overdrive flavours you need for a perfect taste every time. Inside this rugged and sturdy metal chassis lies a circuit that brews a fine range of overdrive tones. These work in harmony with your guitar’s natural character to bring your playing to life. Brew your own distinctive overdrive with the Amber Nectar!"),
                new ParagraphModel("This simple to use pedal has three knobs and a micro-switch. Use the switch to toggle between two distinct brands of taste: HALF CUT is a transparent sound full of expressive qualities. It brings confidence and character to your sound without stepping over the line. HAMMERED has more fuel and might: it has become loud and punchy and is a lot of fun! A True-Bypass switch keeps your signal pure and clean."),
                new ParagraphModel("Enhance your Amber Nectar experience with a light seasoning from the TONE knob. This super-expressive control allows you a wide range of EQ possibilities. Make judicious use of the GAIN knob to dial in the potency of your brew. The Amber Nectar pedal is extremely responsive to picking dynamics, so we encourage experimentation, though the Landlord does not recommend mixing drinks!")
            },
            new DownloadLinkModel("SupportPdfs/Amber-Nectar-manual.pdf", manualIconImage),          
            new MetaDataModel("Landlord Amber Nectar Overdrive Guitar Pedal | Landlord FX", "The Landlord FX Amber Nectar Overdrive is a quality two-mode Drive pedal in a compact format with True-Bypass switching.")
        );

        private static ProductModel bangingHangover = new ProductModel(
            new ImageModel("Banging Hangover Product Banner", "Banners/header-banging.jpg"),
            new ImageModel("Banging Hangover HomePage Image", "Home/home-banging.jpg"),
            new ImageModel("Banging Hangover SupportPage Banner", "Support/support-banging.jpg"),
            new ImageModel("Banging Hangover Mobile HomePage Image", "Mobile/mobile-banging.jpg"),
            "banging-hangover",
            "Banging Hangover",
            "Expansive Reverb",
            "Looping has never been easier, more satisfying or as fun",
            new ImageModel[]
            {
                new ImageModel("Banging Hangover Pedal Left Perspective", "Products/Banging-Hangover/details-example-1.jpg"),
                new ImageModel("Banging Hangover Pedal Top Elevation", "Products/Banging-Hangover/details-example-2.jpg"),
                new ImageModel("Banging Hangover Pedal Right Perspective", "Products/Banging-Hangover/details-example-3.jpg"),
                new ImageModel("Banging Hangover Pedal Bottom Elevation", "Products/Banging-Hangover/details-example-4.jpg"),
                new ImageModel("Banging Hangover Pedal Front Elevation", "Products/Banging-Hangover/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("BANGING HANGOVER . REVERB PEDAL"),
                new DescriptionModel("Soothe those slightly raw mornings-after with a lush, expansive reverb from Landlord FX. The Banging Hangover understands your pain and wants to bathe you in gentle tides of ambience. The Banging Hangover offers up three types of reverb in a tough metal package with a true bypass switch for quality and strength to match your most intense ‘recovery periods’."),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("Built like a tank and fully featured, the Landlord FX Banging Hangover is just the pedal to relieve the aches of a late-night session. There are three distinct reverb modes within the Banging Hangover, all designed to bring space and dimension to your guitar sound."),
                new ParagraphModel("Three control knobs and a mini-toggle switch are all you need to soothe away those rough edges. The toggle switch gives you access to three modes: ROOM, a natural and clear reverberation of a medium sized room; PLATE, an echoey, metallic reverb that is distinct and musical; and SPRING, a rich, classic reverb in the style of a vintage amplifier."),
                new ParagraphModel("Use the MIX knob to dial in your perfect dry/reverb balance. Sculpt your sound with the TONE knob: clockwise adds brightness and sheen."),
                new ParagraphModel("Pour yourself a cold drink, plug in your guitar and say goodbye to your hangover with Landlord FX’s Banging Hangover Reverb.")
            },
            new DownloadLinkModel("SupportPdfs/Banging-Hangover-manual.pdf", manualIconImage),
            new MetaDataModel("Landlord Banging Hangover Reverb Guitar Pedal | Landlord FX", "The Landlord FX Banging Hangover is a lush Reverb pedal with a metal chassis and True-Bypass switching.")
        );

        private static ProductModel brewersDroop = new ProductModel(
            new ImageModel("Brewers Droop Product Banner", "Banners/header-droop.jpg"),
            new ImageModel("Brewers Droop HomePage Image", "Home/home-droop.jpg"),
            new ImageModel("Brewers Droop SupportPage Banner", "Support/support-droop.jpg"),
            new ImageModel("Brewers Droop Mobile HomePage Image", "Mobile/mobile-droop.jpg"),
            "brewers-droop",
            "Brewers Droop",
            "Analog Chorus",
            "Classic analog bucket-brigade chorus with variable speed and depth",
            new ImageModel[]
            {
                new ImageModel("Brewers Droop Pedal Left Perspective", "Products/Brewers-Droop/details-example-1.jpg"),
                new ImageModel("Brewers Droop Pedal Top Elevation", "Products/Brewers-Droop/details-example-2.jpg"),
                new ImageModel("Brewers Droop Pedal Right Perspective", "Products/Brewers-Droop/details-example-3.jpg"),
                new ImageModel("Brewers Droop Pedal Bottom Elevation", "Products/Brewers-Droop/details-example-4.jpg"),
                new ImageModel("Brewers Droop Pedal Front Elevation", "Products/Brewers-Droop/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("BREWERS DROOP . CHORUS PEDAL"),
                new DescriptionModel("If your natural performance is a little disappointing, improve your odds of success with this deep and strong chorus effect. Don’t be timid: turn every control to ten and enjoy the sensation with Brewer’s Droop from Landlord FX!"),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("The Landlord FX Brewer’s Droop enhances your modulation performance with a fantastic analog, bucket-brigade (BBD) circuit. No longer will your guitar signal sound weak and tepid! Dial in a lush and warm Chorus sound to bring life to your flat guitar sound."),
                new ParagraphModel("The Brewer’s Droop has a strong metal chassis, a true-bypass footswitch and three simple control knobs. What else do you need to give your tone a lift? LEVEL will add increasing amounts of Chorus to your signal. DEPTH deepens the experience by adding girth and width to the modulation. SPEED lets you take it fast or slow, depending on the experience you’re after. Thick, satisfying chorus sounds are now yours for the taking! The bucket brigade technology effectively adds a natural low pass filter-effect to your tone for a particularly vintage experience.")
            },
            new DownloadLinkModel("SupportPdfs/Brewers-Droop-manual.pdf", manualIconImage),
            new MetaDataModel("Landlord Brewers Droop Chorus Guitar Pedal | Landlord FX", "The Landlord FX Brewers Droop is an analog Chorus pedal with a compact chassis and True-Bypass switching.")
        );

        private static ProductModel frothyHead = new ProductModel(
            new ImageModel("Frothy Head Product Banner", "Banners/header-frothy.jpg"),
            new ImageModel("Frothy Head HomePage Image", "Home/home-frothy.jpg"),
            new ImageModel("Frothy Head SupportPage Banner", "Support/support-frothy.jpg"),
            new ImageModel("Frothy Head Mobile HomePage Image", "Mobile/mobile-frothy.jpg"),
            "frothy-head",
            "Frothy Head",
            "Classic Echo",
            "Vintage-style echo with reverse mode and a recallable storage",
            new ImageModel[]
            {
                new ImageModel("Frothy Head Pedal Left Perspective", "Products/Frothy-Head/details-example-1.jpg"),
                new ImageModel("Frothy Head Pedal Top Elevation", "Products/Frothy-Head/details-example-2.jpg"),
                new ImageModel("Frothy Head Pedal Right Perspective", "Products/Frothy-Head/details-example-3.jpg"),
                new ImageModel("Frothy Head Pedal Bottom Elevation", "Products/Frothy-Head/details-example-4.jpg"),
                new ImageModel("Frothy Head Pedal Front Elevation", "Products/Frothy-Head/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("FROTHY HEAD . ECHO PEDAL"),
                new DescriptionModel("Pour your guitar sound into some thick and luxurious echo for a satisfying and addictive tone brew! The Landlord FX Frothy Head uses 44.1kHz/24 bit sampling technology to bring a vintage-style echo with the option of storing your favourite settings! Tasty!"),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("Classic pints of beer back in the day always had a good frothy head: it was part of the taste and experience. Landlord FX bring back that halcyon era with the Frothy Head Echo, a tasty, vintage flavoured experience in itself!"),
                new ParagraphModel("A sturdy metal chassis and heavy-duty True-Bypass switch mark the Frothy Head out as a pedal for the ages. Sonically, your sound will taste more interesting with more flavours and depth rising to the top. A mini-toggle switch gives you instant access to three modes: DARK, the classic ambient echo sound with the treble frequencies rolled off; LITE, a clean sounding delay with just a hint of froth and fizz; and REVERSE, a special mode that turns your playing back-to-front for wild, psychedelic soundscapes."),
                new ParagraphModel("Three simple knobs let you assume control over Level, number of Repeats and delay Time. Nothing could be simpler! Accept no drinks unless they have a Frothy Head!")
            },
            new DownloadLinkModel("SupportPdfs/Frothy-Head-manual.pdf", manualIconImage),
            new MetaDataModel("Landlord Frothy Head Echo Guitar Pedal | Landlord FX", "The Landlord FX Frothy Head brings delicious vintage echo into a compact, road-worthy format.")
        );

        private static ProductModel happyHour = new ProductModel(
            new ImageModel("Happy Hour Product Banner", "Banners/header-happy.jpg"),
            new ImageModel("Happy Hour HomePage Image", "Home/home-happy.jpg"),
            new ImageModel("Happy Hour SupportPage Banner", "Support/support-happy.jpg"),
            new ImageModel("Happy Hour Mobile HomePage Image", "Mobile/mobile-happy.jpg"),
            "happy-hour",
            "Happy Hour",
            "Compact Looper",
            "Creative and effective looper and overdub effects made easy",
            new ImageModel[]
            {
                new ImageModel("Happy Hour Pedal Left Perspective", "Products/Happy-Hour/details-example-1.jpg"),
                new ImageModel("Happy Hour Pedal Top Elevation", "Products/Happy-Hour/details-example-2.jpg"),
                new ImageModel("Happy Hour Pedal Right Perspective", "Products/Happy-Hour/details-example-3.jpg"),
                new ImageModel("Happy Hour Pedal Bottom Elevation", "Products/Happy-Hour/details-example-4.jpg"),
                new ImageModel("Happy Hour Pedal Front Elevation", "Products/Happy-Hour/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("HAPPY HOUR . LOOPER PEDAL"),
                new DescriptionModel("Happy hour is the best time of the day: relive it over and over with endless loops from FX’s Happy Hour. Have fun bringing new creativity to your playing with unlimited overdubs and 10mins’ worth of recording time, all in a simple and convenient design. With Landlord FX, it’s always Happy Hour!"),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("Happy hour is about keeping things simple and fun. Landlord FX’s Happy Hour looper pedal is an extremely powerful and extremely straightforward looping device. Built into its sturdy metal chassis is a staggering 10 mins’ worth of high quality, clear looping! "),
                new ParagraphModel("This is all achieved with only one heavy duty footswitch and one control knob: happy days indeed! The LED indicator will change colour to indicate your recording status. It’s easy: tap once to record (LED is red); tap again for Playback mode (LED is green); tap the pedal again and you can overdub new parts (LED red again); tap the footswitch one last time to return to Playback mode."),
                new ParagraphModel("Hold the footswitch down for 2 secs to delete a line: do the same again to restore the deleted line!"),
                new ParagraphModel("Looping has never been easier, more satisfying or as fun as with the Landlord FX Happy Hour looper!")
            },
            new DownloadLinkModel("SupportPdfs/Happy-Hour-manual.pdf", manualIconImage),
            new MetaDataModel("Landlord Happy Hour Looper Guitar Pedal | Landlord FX", "The Landlord FX Happy Hour is a compact and powerful looper with 10 mins recording time and True-Bypass switching.")
        );

        private static ProductModel lockIn = new ProductModel(
            new ImageModel("Lock In Product Banner", "Banners/header-lock-in.jpg"),
            new ImageModel("Lock In HomePage Image", "Home/home-lock-in.jpg"),
            new ImageModel("Lock In SupportPage Banner", "Support/support-lock-in.jpg"),
            new ImageModel("Lock In Mobile HomePage Image", "Mobile/mobile-lock-in.jpg"),
            "lock-in",
            "Lock In",
            "Chromatic Tuner",
            "Compact and highly visible chromatic tuner with True-Bypass switching",
            new ImageModel[]
            {
                new ImageModel("Lock In Pedal Left Perspective", "Products/Lock-In/details-example-1.jpg"),
                new ImageModel("Lock In Pedal Top Elevation", "Products/Lock-In/details-example-2.jpg"),
                new ImageModel("Lock In Pedal Right Perspective", "Products/Lock-In/details-example-3.jpg"),
                new ImageModel("Lock In Pedal Bottom Elevation", "Products/Lock-In/details-example-4.jpg"),
                new ImageModel("Lock In Pedal Front Elevation", "Products/Lock-In/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("LOCK IN . TUNER PEDAL"),
                new DescriptionModel("Before attempting any long evening session, make sure you have your fundamentals sorted: that means using a great tuner. The Landlord FX Lock In Tuner brings you accurate chromatic tuning for guitar and bass! Lock in your tuning and be assured of lasting the distance!"),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("The Landlord FX Lock In Tuner is housed in a sturdy metal chassis with a large, bright LED display. With this display, you will get pinpoint accuracy of your tuning with both ‘floating needle’ and note name display. No matter how long your lock in lasts, this display will remain visible!"),
                new ParagraphModel("This tuner is chromatic: this means that altered tunings are not a problem! The Lock In will happily work with 7 string guitars and 5 string basses so it will earn its place on every pedal board. It simply reads the frequency being played into it and shows the result clearly on the display."),
                new ParagraphModel("The Landlord FX Lock In Tuner gives you what you need, where and when you need it.")
            },
            new DownloadLinkModel("SupportPdfs/Lock-In-manual.pdf", manualIconImage),
            new MetaDataModel("Landlord Lock In Tuner Guitar Pedal | Landlord FX", "The Landlord FX Lock In is a compact chromatic tuner for guitar and bass with a large display and True-Bypass switching.")
        );

        private static ProductModel spinningRoom = new ProductModel(
            new ImageModel("Spinning Room Product Banner", "Banners/header-spinning.jpg"),
            new ImageModel("Spinning Room HomePage Image", "Home/home-spinning.jpg"),
            new ImageModel("Spinning Room SupportPage Banner", "Support/support-spinning.jpg"),
            new ImageModel("Spinning Room Mobile HomePage Image", "Mobile/mobile-spinning.jpg"),
            "spinning-room",
            "Spinning Room",
            "Multiple Modulation",
            "Compact, Multiple Modulation Pedal with True-Bypass Switching",
            new ImageModel[]
            {
                new ImageModel("Spinning Room Pedal Left Perspective", "Products/Spinning-Room/details-example-1.jpg"),
                new ImageModel("Spinning Room Pedal Top Elevation", "Products/Spinning-Room/details-example-2.jpg"),
                new ImageModel("Spinning Room Pedal Right Perspective", "Products/Spinning-Room/details-example-3.jpg"),
                new ImageModel("Spinning Room Pedal Bottom Elevation", "Products/Spinning-Room/details-example-4.jpg"),
                new ImageModel("Spinning Room Pedal Front Elevation", "Products/Spinning-Room/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("SPINNING ROOM . MODULATION PEDAL"),
                new DescriptionModel("If the Landlord has called time on your evening, plug into this pedal until your room starts spinning with an incredible selection of modulation effects! The Landlord FX Spinning Room packs no less than 11 modulation effects into a mini chassis along with True-Bypass switching! Don’t stop until you have double vision!"),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("Get much more than you bargained for with the Landlord FX Spinning Room. Hold on to the walls or indeed the floor because you do not want to fall off! This sturdy pedal houses 11 modulation effects under its metal hood. A master control knob selects the effect and a further three control knobs give you command of DEPTH, SPEED and LEVEL."),
                new ParagraphModel("The Spinning Room is your one-stop shop for all things modulation: Choruses, Flangers, a Phaser, Tremolo, Filter and many more effects are ready to modulate your mind into submission. Every pedalboard needs a dose of psychedelic whoosh: get a whole collection of quality effects in one compact pedal with the Landlord FX Spinning Room.")
            },
            new DownloadLinkModel("SupportPdfs/Spinning-Room-manual.pdf", manualIconImage),
            new MetaDataModel("Landlord Spinning Room Modulator Guitar Pedal | Landlord FX", "The Landlord FX Spinning Room is a powerful multiple modulation device in a compact pedal housing.")
        );

        private static ProductModel tapRoom = new ProductModel(
            new ImageModel("Taproom Product Banner", "Banners/header-taproom.jpg"),
            new ImageModel("Taproom HomePage Image", "Home/home-taproom.jpg"),
            new ImageModel("Taproom SupportPage Banner", "Support/support-taproom.jpg"),
            new ImageModel("Taproom Mobile HomePage Image", "Mobile/mobile-taproom.jpg"),
            "taproom",
            "Taproom",
            "Essential Delay",
            "Clean and fresh digital delay with unique self-oscillation feature",
            new ImageModel[]
            {
                new ImageModel("Taproom Pedal Left Perspective", "Products/Taproom/details-example-1.jpg"),
                new ImageModel("Taproom Pedal Top Elevation", "Products/Taproom/details-example-2.jpg"),
                new ImageModel("Taproom Pedal Right Perspective", "Products/Taproom/details-example-3.jpg"),
                new ImageModel("Taproom Pedal Bottom Elevation", "Products/Taproom/details-example-4.jpg"),
                new ImageModel("Taproom Pedal Front Elevation", "Products/Taproom/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("TAPROOM . DELAY PEDAL"),
                new DescriptionModel("Treat your tone to a measure of finely brewed delay with the Landlord FX Taproom Delay! Taproom keeps things simple, delivering a tasty, clean delay sound with plenty of oscillating feedback and a True-Bypass switch for enduring quality."),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("The Landlord FX Taproom is an inspiring digital delay effect. The Landlord keeps his taps clean at all times and the same is true for the delay repeats in this pedal! Pristine, clear and beautiful, the Tap Room gives you all of the ambience and extra rhythm you crave, along with a little madness at higher settings!"),
                new ParagraphModel("The Taproom, like all other Landlord FX pedals, is built like a tank. The chassis is solid metal and the True-Bypass switch is heavy-duty. On the surface, three simple control knobs are all you need to tap into some great delay sounds!"),
                new ParagraphModel("TIME adjusts the flow of the delay effect. Long, slow repeats of 620ms are available, as are super-fast delays of 20ms. REPEAT determines how often that delay signal sounds out its echoes. From a trickle to a flood, you can open the taps as wide as you want! On the higher settings, the repeats will actually self-oscillate! Bring a little wildness to your sound with the Taproom! LEVEL determines the balance of clean sound versus lush Taproom delay. Adjust to find your perfect sound!"),
                new ParagraphModel("Add the Landlord FX Taproom delay to your pedalboard for a high quality and adaptable go-to delay.")
            },
            new DownloadLinkModel("SupportPdfs/Taproom-manual.pdf", manualIconImage),
            new MetaDataModel("Landlord Taproom Delay Guitar Pedal | Landlord FX", "The Landlord FX Taproom is a compact 620ms delay with self-oscillating repeats and True-Bypass switching.")
        );

        private static ProductModel whiskeyChaser = new ProductModel(
            new ImageModel("Whiskey Chaser Product Banner", "Banners/header-whiskey.jpg"),
            new ImageModel("Whiskey Chaser HomePage Image", "Home/home-whiskey.jpg"),
            new ImageModel("Whiskey Chaser SupportPage Banner", "Support/support-whiskey.jpg"),
            new ImageModel("Whiskey Chaser Mobile HomePage Image", "Mobile/mobile-whiskey.jpg"),
            "whiskey-chaser",
            "Whiskey Chaser",
            "High Gain Distortion",
            "High gain distortion with multiple modes that span classic and modern tones with bite and attitude",
            new ImageModel[]
            {
                new ImageModel("Whiskey Chaser Pedal Left Perspective", "Products/Whiskey-Chaser/details-example-1.jpg"),
                new ImageModel("Whiskey Chaser Pedal Top Elevation", "Products/Whiskey-Chaser/details-example-2.jpg"),
                new ImageModel("Whiskey Chaser Pedal Right Perspective", "Products/Whiskey-Chaser/details-example-3.jpg"),
                new ImageModel("Whiskey Chaser Pedal Bottom Elevation", "Products/Whiskey-Chaser/details-example-4.jpg"),
                new ImageModel("Whiskey Chaser Pedal Front Elevation", "Products/Whiskey-Chaser/details-example-5.jpg"),
            },
            new ContentModel[]
            {
                new HeadingModel("WHISKEY CHASER . DISTORTION PEDAL"),
                new DescriptionModel("The Landlord FX Whiskey Chaser is a vicious sounding high gain distortion with enough kick to cut through the worst of musical hangovers. Dial in the midrange with the Tone knob and be very careful with the Gain control: adjust to taste!"),
                new SubHeadingModel("CONTROLS"),
                new ParagraphModel("The Landlord FX Whiskey Chaser offers a range of strong distortion flavours. A mini toggle switch lets you choose the strength of your chaser but do be careful: the temptation to dive in at the deep end may be more than you bargained for! Trust the landlord! The three modes of the switch bring three distinct flavours of drive to the table: HOOCH has a natural break up and clear colour; SCOTCH is a golden, warm-tasting high gain sound; and BOURBON is a dark, slamming hit of gain with a modern tone and a tight low end."),
                new ParagraphModel("The three knobs give you control over your session. LEVEL brings the balance between beer and whiskey. At its maximum setting, there is quite a volume boost, especially the BOURBON mode! DISTORTION lays on the pain so be careful if you are planning a long night! There is an ocean full of gain here so try your sound as you wind up the DISTORTION knob to get your optimum strength. TONE dials in the taste and brings plenty of midrange to the recipe."),
                new ParagraphModel("The Landlord FX Whiskey Chaser is a strong pedal that certainly makes its presence known! Hard Rock and Metal players will love a shot or two of the Whiskey Chaser.")
            },
            new DownloadLinkModel("SupportPdfs/Whiskey-Chaser-manual.pdf", manualIconImage),
            new MetaDataModel("Landlord Whiskey Chaser Distortion Guitar Pedal | Landlord FX", "The Landlord FX Whiskey Chaser is a three mode High Gain distortion in a compact format with True-Bypass switching.")
        );

        private static CategoryModel[] categories = new CategoryModel[]
        {
            new CategoryModel("Delay", new ProductModel[] { frothyHead, tapRoom }),
            new CategoryModel("Reverb", new ProductModel[] { bangingHangover }),
            new CategoryModel("Distortion", new ProductModel[] { whiskeyChaser }),
            new CategoryModel("Drive", new ProductModel[] { amberNectar }),
            new CategoryModel("Modulation", new ProductModel[] { brewersDroop, spinningRoom }),
            new CategoryModel("Tuner", new ProductModel[] { lockIn }),
            new CategoryModel("Looper", new ProductModel[] { happyHour }),
            new CategoryModel("Dynamics", new ProductModel[] { aCheekyPint })
        };

        private static IEnumerable<ProductModel> products = new ProductModel[]
        {
            brewersDroop,
            bangingHangover,
            happyHour,
            spinningRoom,
            frothyHead,
            aCheekyPint,
            whiskeyChaser,
            tapRoom,
            amberNectar,
            lockIn
        };

        public IEnumerable<CategoryModel> GetCategories()
        {
            return categories;
        }

        public ProductModel GetProduct(string productName)
        {
            try
            {
                return products.Single(a => a.Name == productName);
            }
            catch(InvalidOperationException)
            {
                throw new ClientException();
            }
        }

        public IEnumerable<ProductModel> GetAllProducts()
        {
            return products;
        }
    }
}
