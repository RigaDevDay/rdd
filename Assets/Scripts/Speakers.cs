using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Speakers : Dictionary<string, Dictionary<string, string>>
{
	public Speakers ()
	{
		/* Day 1 */

		/* 11:30 */
	
		/* Room 1 */
		Dictionary<string, string> data = new Dictionary<string, string> ();
		data.Add ("topic", "Prepare for JDK 9!");
		data.Add ("name", "Dalibor Topic");
		data.Add ("position", "Principal Product Manager at Oracle");
		data.Add ("description", "The modularization of the Java SE Platform in JDK 9 will bring many benefits, but also many changes. Existing code that uses only official Java SE Platform APIs and supported JDK-specific APIs should continue to work without change. Code that uses certain deprecated features, however, or any JDK-internal APIs, is likely to break. This session will show you how to prepare existing libraries and applications for JDK 9, and how to get old code working on JDK 9 even when you can't update it.");
		this.Add ("Dalibor Topic", data);		

		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "The Mayans Lost Guide to RxJava on Android");
		data.Add ("name", "Fernando Cejas");
		data.Add ("position", "Engineer at SoundCloud");
		data.Add ("description", "This is an introduction to RxJava on Android. Basically, we will walk through the main concepts behind RxJava for Android and Reactive Programming, with examples, use cases and good practices when applying it on our projects.");
		this.Add ("Fernando Cejas", data);

		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "The Language of Regular Expressions. So You Think You Can Speak It?");
		data.Add ("name", "Rustam Mehmandarov");
		data.Add ("position", "Principal Engineer at Computas AS");
		data.Add ("description", "[Teaser: They are everywhere, they are magical and their knowledge can help you stand out from the crowd. They are also fast and can save time. Lots of time. Do you want to understand and learn to use them properly?]Want to slay the monsters that leave [stack-] traces in your log files or to tackle the naming conventions in your code? Maybe you just want to understand better the charms that has been written (cast) by others?In this workshop, we will be taking a deeper dive into regular expressions, their use and practical examples. We will start with a short intro to the mysterious world of reg.ex. and brush up on our knowledge before continuing on to more advanced topics like groups, greed, and backtracking. It will be an interactive presentation with demos.");
		this.Add ("Rustam Mehmandarov", data);

		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Oracle 12c for Developers");
		data.Add ("name", "Alex Nuijten");
		data.Add ("position", "Key Consultant at Ordina");
		data.Add ("description", "Do you want to get up to speed with the most current release of the Oracle database? Then this session is for you. You will learn the most exciting and most useful new features from the Oracle Database 12c which can make your work as database developer a lot easier. There is more to the Oracle database 12c than just pluggable databases.");
		this.Add ("Alex Nuijten", data);

		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("name", "?");
		data.Add ("topic", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* 13:30 */

		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Appium: Mobile Automation Made Awesome");
		data.Add ("name", "Dan Cuellar");
		data.Add ("position", "Head of Software Testing at FOODit");
		data.Add ("description", "The tools and practices refined over the last decade by web developers have not crossed over easily into the mobile community. Mobile devs have been without tools like continuous integration and automated testing, which enable delivery of high-quality apps more rapidly. A key piece of the solution for mobile is Appium, an open-source, cross-platform, language-agnostic mobile automation framework you can use to write automated UI tests for Android and iOS apps (native, hybrid, web), to be run on emulators or devices. In this talk we will explore the philosophy that underlies the work behind Appium, including the open-source nature of Appium’s diverse, active and friendly community. Then, after a brief explanation of the technology that powers Appium, we’ll move into the technical portion of the talk, where attendees will see easy it is to write Appium scripts using the WebDriver protocol in their favorite language.");
		this.Add ("Dan Cuellar", data);

		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Integration Testing from the Trenches");
		data.Add ("name", "Nicolas Fränkel");
		data.Add ("position", "Senior Consultant at Hybris");
		data.Add ("description", "When one uses Test-Driven Development, has more then 90% test coverage and the best Sonar metrics ever seen, and still finds regular bugs in his application, it is time for something more. Unit Testing is like testing a car's every nuts and bolts while Integration Testing is like leading it on a test drive: one cannot achieve high internal quality without the other. However, Integration Testing might seem very complex when put in place for the first several times; I have made many mistakes and have lost much time. In this presentation, I will present tools that helped me tremendously in Integration Testing, as well as proven tactics to get the best out of your tests.");
		this.Add ("Nicolas Frankel", data);

		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "50 Shades of #Fail - OBI worst practices in real life");
		data.Add ("name", "Christian Berg");
		data.Add ("position", "CEO at Dimensionality");
		data.Add ("description", "Lists of \"best practices\" as well as \"how-to's\" on the subject of Oracle BI and all its facets are commonplace and often discussed. Real-life practices, however, are a completely different story. What happens when implementations go astray or dogmatically follow half-knowledge, misconceptions, or conveniently cheap shortcuts? Learn about recurring pitfalls, their origins, their impacts, and most importantly their remedies in an entertaining fashion. However bad you thought your project was, you’ve seen nothing yet...");
		this.Add ("Christian Berg", data);

		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* 14:30 */
		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "JSR377: What's up and what's next");
		data.Add ("name", "Andres Almiray");
		data.Add ("position", "Canoo Fellow at Canoo Engineering AG");
		data.Add ("description", "JSR-377, the Desktop|Embedded Application API JSR has as a goal to standardize common behavior shared by many desktop applications. This behavior can also be applied to the emerging Java Embedded and Internet-of-Things applications. Because the JSR targets multiple toolkits (Swing, JavaFX, SWT and more) it's even possible to build applications targeting the mobile space (JavaFX on mobile). There are a good number of framework and platforms that deliver these features in their own way. In this talk we'll discuss the current state of this JSR and explore its features.");
		this.Add ("Andres Almiray", data);

		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "An introduction to cross-platform development with Xamarin");
		data.Add ("name", "Gill Cleeren");
		data.Add ("position", "Architect at Ordina Belgium");
		data.Add ("description", "Cross platform development is what many business consider as the holy grail. There have been many attempts over the years and all have their flaws. One of the major problems is that many solutions require learning a new language and skillset, while that is often – if not always – the most valuable asset. With Xamarin, it becomes possible to re-use C# skills to build iOS and Android applications and on top of that, re-use much of the code base for both Windows 8 and Windows Phone 8 apps. In this introduction session, we will take a look at how we can build apps using C# which run on all platforms. We will also take a look at the different code-sharing strategies which we have available, including PCLs, shared code and more. With Xamarin, development can be done from Visual Studio as well as from Xamarin Studio; we’ll show the different options here as well. After this session, you’ll have a good overview of what Xamarin can help you with and also what are the different building blocks of the platform.");
		this.Add ("Gill Cleeren", data);

		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Getting Your IoT Things Talking");
		data.Add ("name", "Jessica Rose");
		data.Add ("position", "Developer Relations at DreamFactory");
		data.Add ("description", "As an increasing number of connected devices enter our world, we’re faced with the challenge of making sure these machines are able to quickly and efficiently talk to us and each other. REST APIs are an amazing way to facilitate these exchanges, but building endless custom APIs doesn’t scale. We’ll be looking at how the generation of reusable REST APIs via DreamFactory’s open source platform can be leveraged to get all the IoT things in your life chatting happily.");
		this.Add ("Jessica Rose", data);

		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "If You Don't Have a Mobile Strategy You Don't Have a Strategy");
		data.Add ("name", "Grant Ronald");
		data.Add ("position", "Director of Product Management for Development and Mobility Tools at Oracle");
		data.Add ("description", "Regardless of how you slice and dice the figures, facts or opinions, mobile is the “internet” of today’s Millennial generation. So what is your strategy with dealing with a cloud-embracing, socially-involved, always-connected, mobile consumer base? The very people who are not only your future customers and employees, are probably already the majority of your consumers today. In this presentation I’m going to give an insight of the challenges presented by mobile then take a dive into the tools and technologies that we are developing here at Oracle to allow you to implement that strategy. I’ll show you how you can build on-device mobile applications. I’ll discuss the challenges of web applications on mobile. I’ll ditch the powerpoints and demo some of our current and future cloud based offerings for exposing your existing legacy assets to mobile consumers. And I’ll even show you how you can develop mobile and cloud based applications, from a mobile device! The future is here, its mobile and if you don’t have mobile strategy you don’t have a strategy.");
		this.Add ("Grant Ronald", data);

		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Migrating to Oracle Cloud using the Oracle Database In-Memory Advisor");
		data.Add ("name", "Julian Dontcheff");
		data.Add ("position", "Global Database Lead at Accenture");
		data.Add ("description", "The presentation is about best practices for how to test new Oracle options using Oracle database cloud. When a multitenant database running on premise needs to be migrated to the Oracle database cloud one should consider the performance load caused by one or more PDBs inside the container. Especially the impact of upgrading to in-memory (12.1.0.2) on the PDBs. We show how to use the in-memory advisor in order to tune the existing structures for in-memory and how to validate this on the database cloud using RAT & SQL tuning advisor.");
		this.Add ("Julian Dontcheff", data);

		/* 16:00 */
		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Having fun with Javassist");
		data.Add ("name", "Anton Arhipov");
		data.Add ("position", "Software Engineer and XRebel Product Lead at ZeroTurnaround");
		data.Add ("description", "Javassist makes Java bytecode manipulation simple. At ZeroTurnaround we use Javassist a lot to implement the integrations for our tools. In this talk we will go through the examples of how Javassist can be applied to alter the applications behaviour and do all kind of fun stuff with it. Why is it interesting? Because while trying to do unusual things in Java, you learn much more about the language and the platform itself and learning about Javassist will actually make you a better Java developer!");
		this.Add ("Anton Arhipov", data);

		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Distributed Systems at ok.ru");
		data.Add ("name", "Oleg Anastasyev");
		data.Add ("position", "Leading developer at Odnoklassniki.ru");
		data.Add ("description", "ok.ru is one of top 10 internet sites of the World, according to similarweb.com. Under the hood, it has several thousand servers. Each of those servers own only fraction of the data or business logic. Shared nothing architecture can be hardly applied to social network, due to its nature, so a lot of communication happens between these servers, diverse in kind and volume. This makes ok.ru one of the largest, complicated, yet highly loaded distributed systems in the world.This talk is about our experience in building always available, resilient to failures distributed systems in Java, their basic and not so basic failure and recovery scenarios, methods of failure testing and diagnostics. We’ll also discuss on possible disasters and how to prevent or get over them.");
		this.Add ("Oleg Anastasyev", data);

		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Finding All the Red M&Ms: A Story of Indexes and Full Table Scans");
		data.Add ("name", "Chris Saxon");
		data.Add ("position", "Developer Advocate for SQL at Oracle");
		data.Add ("description", "'Why isn’t my query using an index?' is a common question people have when tuning SQL. This talk explores the factors that influence the optimizer’s decision behind this question. It does so by comparing fetching rows from a database table to finding all the red M&Ms from their bags. It contrasts using an index range scan and a full table scan to do this. It introduces the concepts of blocks and the clustering factor. It discusses how these affect the optimizer's calculations. It goes on to demonstrate how these concepts work in practice using real SQL queries. This session is intended for developers and DBAs who want to learn the basics of how the optimizer chooses between an index range or full table scan.");
		this.Add ("Chris Saxon", data);

		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* 17:00 */
		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Modular Development With JDK 9");
		data.Add ("name", "Dalibor Topic");
		data.Add ("position", "Principal Product Manager at Oracle");
		data.Add ("description", "First part will be a a gentle introduction, with examples, to the forthcoming Java Platform Module System. Learn how to create a module from scratch, compile it, test it, and run it. This session will also show basic techniques for modularizing existing libraries and applications. Second part : Modularizing an existing library or application, or creating new modules from scratch, can raise many difficult and subtle design issues. This session will present a set of principles for modular development, with examples taken from the JDK itself.");
		this.Add ("Dalibor Topic2", data);
		
		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
		this.Add ("?", data);

		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Where do we go after Http 1.1 - Http2");
		data.Add ("name", "Mihail Stoynov");
		data.Add ("position", "Board Member at jug.bg");
		data.Add ("description", "What is Http2? How is it supported in Java? How easy is to implement it? Why is it so much faster? How will http2 improve wifi? This session is the answer and a practical demonstration of how easy it is to migrate to the next gen of http.");
		this.Add ("Mihail Stoynov", data);
		
		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "SQL Model Clause: A Gentle Introduction");
		data.Add ("name", "Alex Nuijten");
		data.Add ("position", "Key Consultant at Ordina");
		data.Add ("description", "The Model Clause adds spreadsheet-like functionality to the SQL language. Very powerful stuff, yet the syntax can be quite daunting. With the Model Clause, you define a multidimensional array from query results and then apply formulas to this array to calculate new values. This presentation will give you a gentle introduction in the complex syntax of the Model Clause and will show you some real life examples where the Model Clause was invaluable.");
		this.Add ("Alex Nuijten2", data);
		
		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* 18:00 */
		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);
		
		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Automated Android CI, how hard can it be?");
		data.Add ("name", "Nicolas Fränkel");
		data.Add ("position", "Senior Consultant at Hybris");
		data.Add ("description", "I'm not an Android developer by far, but I'm working in a mobile development team as the DevOps guy, which basically translates to do anything that is not related to development proper. When I was introduced to the team, they had hacked something on a Bamboo server, based on custom Python scripts that uploaded the binaries to a Hockeykit, completely decoupled from the Maven build and the Nexus repository. The they decided to switch to Gradle... In this presentation, I will describe how I migrated from this situation to the following: * a full-fledged Jenkins server provisioned with Puppet * provisioning of the Android SDK manager * provisioning of Gradle * updates of the platforms, extras and repositories behind the entreprise proxy * creation of Gradle jobs managing Hockeykit files creation, upload of the whole outputs to Nexus and tagging Git for releases builds");
		this.Add ("Nicolas Frankel2", data);
		
		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);
		
		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Back2Basics: A day in the life of an Oracle BI query");
		data.Add ("name", "Christian Berg");
		data.Add ("position", "CEO at Dimensionality");
		data.Add ("description", "Oracle BI is in use since years, has gone through many interations and is wide-spread across projects around the globe. Millions of analyses have been created, deployed and run billions of times. The actual lifecycle of an Oracle BI query from its inception through to the effective delivery of results may therefor be regarded as a given commodity not requiring a closer look. Few people have regarded an OBI query from the point of view \"How does it get constructed? How does it get translated between the different architectural components and the RPD layers? How, through what and where does its lifecycle get influenced? Where can we as users/developers/administrators actively intervene with its makeup and structure? Why do we genuinely have to have an understanding of the subtleties of the life-cycle in order to create successful BI solutions?\" The purpose of this presentation is to serve as an introductory session for beginners while at the same serving as a reflective discussion of a topic regarded as \"god-given / it just IS\" by the wider population of users (including intermediates). Theoretical examination of the possible steps and paths the query lifecycle can take is depicted with simple but speaking examples. The impact of factors like basic analysis construction in Answers, advanced SQL clauses, caching, business model peculiarities like multi-star queries, snowflaking and LTS modelling as well as physical layer settings like call interfaces, data source parametrization or inclusion of hints in the RPD are to be showcased.");
		this.Add ("Christian Berg2", data);
		
		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);


		/* Day 2 */

		/* 10:20 */
		/* Day 2 Opening */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "The Web - What it Has, What it Lacks and Where it Must Go");
		data.Add ("name", "Robert Nyman");
		data.Add ("position", "Developer Relations Program Manager at Google");
		data.Add ("description", "Taking a look at the web where it is today: the myriad of new features and possibilities we have gotten, and how the web needs to evolve to stay relevant. To give a perspective on where it came from and also comparing it to other platforms to see where we need to move forward. Getting a perspective on SLICE, Progressive Apps and thoughts about how the web can, and should be, unique.");
		this.Add ("Robert Nyman", data);

		/* 11:30 */
		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Modern Java Component Design with Spring 4.3");
		data.Add ("name", "Juergen Hoeller");
		data.Add ("position", "Spring Framework project lead at Pivotal");
		data.Add ("description", "Juergen Hoeller is co-founder of the Spring Framework open source project and has been serving as the project lead and release manager for the core framework since 2003. Juergen is an experienced software architect and consultant with outstanding expertise in code organization, transaction management and enterprise messaging.");
		this.Add ("Juergen Hoeller", data);

		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Angular 2 Component Router");
		data.Add ("name", "Gerard Sans");
		data.Add ("position", "AngularJS Senior Developer at Freelance");
		data.Add ("description", "Angular 2 comes with a new router that replaces previous ngRoute. We will compare the new router with ui-router and show how we can setup multiple views and nested routes.");
		this.Add ("Gerard Sans", data);

		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Kotlin on Android");
		data.Add ("name", "Svetlana Isakova");
		data.Add ("position", "Kotlin developer at JetBrains");
		data.Add ("description", "Développement Android Apple has introduced “a better language” for iOS developers. But what options do we have for Android? Surely Kotlin should be under consideration! Android Studio is now based on Intellij Idea, the “native” environment for Kotlin. Kotlin is a modern language for industry. It can help you reduce the amount of code you write for Android applications and at the same time make it readable and more maintainable. In this session we are going to talk a bit why JetBrains sees the potential in Kotlin comparing to other JVM languages. Then we’ll see how certain language constructs can be used to make Android more enjoyable. Also we’ll look at a DSL for type-safe dynamic layouts and a simple extension plugin that helps to avoid writing ‘findViewById()’ all the time.");
		this.Add ("Svetlana Isakova", data);

		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Java, Docker and 'The Cloud'");
		data.Add ("name", "James Thomas");
		data.Add ("position", "Developer Advocate at IBM");
		data.Add ("description", "Deploying your application to the production has failed again. Emailing the developer who commited the last code changes, they send back the classic response... “It works on my machine”. *sigh* Is this scenario a recurring nightmare (and reality) for you? While everyone else is talking about “continuous delivery” do your deployments feel more like an extreme game of Jenga, tittering on the brink of disaster and a nightmare to reconstruct? It doesn’t have to be like this. Launched only two years ago, Docker has revolutionised application deployment. Using this open-source project, applications are packaged into lightweight containers, that are hardware and platform agnostic. Containers move from the local developer machine to a production server and then the cloud without modification! So, how do you migrate a traditional three-tier Java web application to use Docker? Let’s use a sample web application, designed for hosting on a single server, convert it to use Docker and deploy to a cloud platform. We’ll break out the application and component services into individual containers that can be ran and scaled independently. Showing you how to utilise existing pre-built images for rapid development, build custom container images for your application and move seamlessly between deployment platforms, enabling us to use “cloud” to accelerate application development. We will configure automatic build, test and deploy pipelines for continuous deployment and auto-scaling to handle unpredictable application traffic with ease. If you’re an application developer who’s exhausted from battling deployment issues, maintaining ”special” production servers and lives in fear of being on ”pager duty”, come and learn how you can use Docker to banish “works on my machine” syndrome. This talk is for developers who’ve heard about this “Docker thing” and want to see a practical example of converting a traditional monolithic web application to use Docker containers deployed to a scalable cloud platform.");
		this.Add ("James Thomas", data);

		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* 13:30 */
		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Spring Data, Hypermedia and the Cloud");
		data.Add ("name", "Christoph Strobl");
		data.Add ("position", "Software Engineer at Pivotal Software, Inc.");
		data.Add ("description", "HATEOAS, REST, JSON Schema, APLS, Cloud, Docker,... are those just buzzwords? No! With Spring Data we allow you to expose your repositories as a REST resource including ALPS metadata, JSON Schema and simply everything you would probably expect. Join Christoph Strobl on his journey through the Spring stack while creating and deploying REST Services as Docker containers, on Cloud Foundry and Lattice.");
		this.Add ("Christoph Strobl", data);

		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Why postgres SQL deserve noSQL fan respect");
		data.Add ("name", "Quentin ADAM");
		data.Add ("position", "CEO at Clever Cloud");
		data.Add ("description", "Postgres SQL is a plain old SQL DB. Very powerful and very consistent, in some case, project needs an ACID database, but schemaless… With JSON support, postgres is a very interesting tool to provide ACID and some very interesting function (time management, localisation function and data types...) and the schemaless noSQL point of view with json and indexed json. This talk show some great usage and some insigth to build some great application with postgres.");
		this.Add ("Quentin ADAM", data);

		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Entering the new era of Front-end development with ReactJS");
		data.Add ("name", "Robert Haritonov");
		data.Add ("position", "Front-end Development Lead at Liberty Global");
		data.Add ("description", "ReactJS is not just yet another framework to be forgotten after few years, it shifts the concepts of modern front-end development giving us the scalability and control we always strived about. Robert will guide you through key concepts of ReactJS based applications covering all aspects of full stack development and maintenance. This includes component development approach, deep integrated into ReactJS architecture and React Native, which allows to reuse most of UI code, still using the power of Native UI.");
		this.Add ("Robert Haritonov", data);
		
		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Fabric8 Camel Microservices for Docker and Kubernetes");
		data.Add ("name", "Claus Ibsen");
		data.Add ("position", "Principal Software Engineer at Red Hat");
		data.Add ("description", "The so-called experts are saying microservices and containers will change the way we build, maintain, operate, and integrate applications. This talk is intended for Java developers who wants to hear and see how you can develop Java microservices that runs in containers. This talk uses Apache Camel as the Java library to build microservice architectured applications. At first we introduce you to Apache Camel and show how you can easily get started with Camel on your computer, and build a microservice application that runs on CDI and Spring-Boot. The second part of this talk is about running Camel (or any Java project) on Docker and Kubernetes. We start covering the basic concepts you as a Java developer must understand about Kubernetes. Then we show how to migrate Java projects to build as Docker images and deployable on Kubernetes, with help from fabric8 Maven tooling. You will also hear about how to make your microservices scalable and distributed by leveraging the facilities that Kubernetes provides for truly distributed services with load balancing and location independence. You will also see how to manage your container using the Kubernetes CLI and the fabric8 web console. At the end we have a bit of fun with scaling up and down your Camel application to see how resilient the application is, when we kill containers. This talk is a 50/50 mix between slides and demo.");
		this.Add ("Claus Ibsen", data);
		
		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* 14:30 */
		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Testing with Spock. The logical choice");
		data.Add ("name", "Iván López");
		data.Add ("position", "Engineer at Kaleidos");
		data.Add ("description", "Remember the old days when you tested using JUnit? How boring it was? You made a lot of excuses to avoid testing your code. Luckily those dark days now belong to the past because Spock is with us.Spock is a Groovy-based testing and specification framework for Java and Groovy applications that makes writing tests fun again. We can write beautiful and highly expressive tests because of its DSL and all the power that Groovy provides us.In this talk you'll learn the basics of Spock and you'll see how easily you can test a Java application. After the talk you won't have any excuse to don't test your applications, so you have been warned before coming to the talk!");
		this.Add ("Ivan Lopez", data);
		
		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Apache Zeppelin, the missing component for your BigData eco-system");
		data.Add ("name", "DuyHai Doan");
		data.Add ("position", "Cassandra Technical Advocate at Datastax");
		data.Add ("description", "If you are interested in Big Data, you surely have heard about Apache Spark or Apache Cassandra, but do you know Apache Zeppelin ? Do you know that it is possible to draw out beautiful graph using an user-friendly interface out of your Spark RDD or out of Cassandra queries ? In this session, I will introduce Zeppelin by live coding example and highlight its modular architecture which allows you to plug-in any interpreter for the back-end of your choice.");
		this.Add ("DuyHai Doan", data);
		
		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Angular2: key concepts and getting started");
		data.Add ("name", "Maxim Salnikov");
		data.Add ("position", "UI Engineer at ForgeRock");
		data.Add ("description", "On this presentation first we'll go shortly through history of Angular for better understanding what Angular2 was introduced for and why it's not backward-compatible with 1.x. Then we'll list key concepts of Angular2 like cross-component communication, one-directional data flow, user input handling and url routing and others. As a result of our practical hands-on tour we'll discuss the main tools for making our Angular2 life easier and build a functioning app.");
		this.Add ("Maxim Salnikov", data);
		
		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Jenkins at your (continuous) service");
		data.Add ("name", "Andrey Adamovich");
		data.Add ("position", "Software Architect at Aestas/It");
		data.Add ("description", "Jenkins is always ready to serve your software delivery automation needs. And even though there are other alternatives, it is considered a de facto tool that many teams turn to when they need simplicity and rich set of features for their automation. This talk will give an overview of Jenkins ecosystem and its capabilities. As well as it will provide some tips and tricks on what you probably didn't know about Jenkins and it's use cases.");
		this.Add ("Andrey Adamovich", data);
		
		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* 16:00 */
		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Painfree Object-Document Mapping for MongoDB");
		data.Add ("name", "Philipp Krenn");
		data.Add ("position", "Tamer of technology at ecosio");
		data.Add ("description", "Morphia is MongoDB's JPA-like Object-Document Mapping (ODM). However, there is no object-relational impedence mismatch since documents fit the concept of object-orientation much better. This removes a lot of JPA pain, which makes database interactions fun again. On a practical level we take a look at the available annotations and how to map your objects as well as how to easily query data in MongoDB. Next we discuss some patterns on how to solve common requirements, such as the proper use of generics, auto-increments, and the encryption of sensitive data. The talk concludes with some tips and lessons we've learned from using Morphia in production for three years.");
		this.Add ("Philipp Krenn", data);
		
		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "WebGL & WebVR: Take the web to the third dimension");
		data.Add ("name", "Martin Naumann");
		data.Add ("position", "Bit Wizard at Archilogic");
		data.Add ("description", "In this talk you will learn how to unlock the 3rd dimension on the web and use it to create impressive new visualisations, stories and experiences. You will see how WebGL can then be taken even further by using technologies such as Oculus Rift, Google Cardboard or LEAPMotion with WebVR to enable truly immersive experiences right from your browser. We will start with the basics of WebGL and the render pipeline, see how 3D on the web has evolved and what can be done with it and then do a little live coding that will conclude with how Virtual Reality can be implemented with web technologies.");
		this.Add ("Martin Naumann", data);
		
		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Field Notes of Command Line Ninja");
		data.Add ("name", "Rustam Mehmandarov");
		data.Add ("position", "Principal Engineer at Computas AS");
		data.Add ("description", "Have you ever witnessed someone write fancy commands and perform magic from the console. Have you ever wished you could learn, or brush up on, those skills too? Maybe you want to be more effective at your everyday tasks, or need a new topic for the next family dinner? Join us and learn some awesome command line ninja skills. You will be able to find something new no matter your level of experience. The audience will get a chance to show off their skills as well, and there will be small prizes to contributors. The black belt and a little surprise await you at the end of this talk. You can bring your PC with you and hack-along! All you need is a PC or a Mac running OS of your choice - Windows, Linux, or Mac OS. Windows users are advised to have their cmd.exe ready, and to install Cygwin (32-bit).");
		this.Add ("Rustam Mehmandarov2", data);
		
		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);

		/* 17:00 */
		/* Room 1 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Spring Framework 5 - Preview & Roadmap");
		data.Add ("name", "Juergen Hoeller");
		data.Add ("position", "Spring Framework project lead at Pivotal");
		data.Add ("description", "The Spring team is busily working on Spring Framework 5.0, with a release candidate scheduled for Q4 2016. This presentation covers the key themes in Spring 5, based on the current state of development: going Java 8+ across the entire framework codebase, comprehensive support for JDK 9, a strong focus on HTTP/2, and first-class support for Spring-style reactive architectures.");
		this.Add ("Juergen Hoeller2", data);
		
		/* Room 2 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);
		
		/* Room 3 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "Hello EcmaScript2015... and also to you, EcmaScript2016");
		data.Add ("name", "Shay Friedman");
		data.Add ("position", "Founder at CodeValue");
		data.Add ("description", "EcmaScript, the standard which is the base for JavaScript, is finally starting to move fast. It is making JavaScript better and better, providing various different tools to solve our common everyday programming tasks. In this session we will go through what’s new with ES2015 and ES2016, and even get a glimpse of what the exciting future holds for web development!");
		this.Add ("Shay Friedman", data);
		
		/* Room 4 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "It's not always application's fault");
		data.Add ("name", "Tomasz Borek");
		data.Add ("position", "Continuous Learner at Symentis");
		data.Add ("description", "Infrastructure primer for busy developer. Tells what can go wrong when you deploy your application, where infrastructure may influence the end result. Tells devops what they need to give/teach their developers, offering hints how to do so Takes viewer through: monitoring, backups, server room, virtualization, sharing, common problems and offers insight. Flash-based version of this talk is on Prezi. Presented on Atmosphere, Java Developer Days, ChamberConf and Java Day Lviv.");
		this.Add ("Tomasz Borek", data);
		
		/* Room 5 */
		data = new Dictionary<string, string> ();
		data.Add ("topic", "?");
		data.Add ("name", "?");
		data.Add ("position", "?");
		data.Add ("description", "?");
//		this.Add ("?", data);
	

	}
}
