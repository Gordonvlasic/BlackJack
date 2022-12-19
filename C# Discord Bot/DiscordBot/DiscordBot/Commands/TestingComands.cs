using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordBot.Models;
using DSharpPlus.Entities;
using DSharpPlus;
using System.Text.Json;
using MongoDB.Driver;
using MongoDB.Bson;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML.Messaging;

namespace DiscordBot.Commands
{
    
    internal class TestingComands
    {
        public class TestingCommands : BaseCommandModule
        {
            [Command("profile")]
            public async Task Profile(CommandContext ctx)
            {
                Items item = new Items();
                await ctx.Channel.SendMessageAsync($"Profile photo: {ctx.User.AvatarUrl}").ConfigureAwait(false);
            }
            [Command("UserId")]
            public async Task UserId(CommandContext ctx)
            {

                await ctx.Channel.SendMessageAsync($"User Id is: {ctx.User.Id}").ConfigureAwait(false);
                ulong a = ctx.User.Id;

            }
            [Command("EnlargeID")]
            public async Task EnlargePhoto(CommandContext ctx, ulong a)
            {
                await ctx.Channel.SendMessageAsync($@"https://discord-avatar.com/en/user/{a}").ConfigureAwait(false);
            }

            [Command("tate")]
            public async Task Tate(CommandContext ctx)
            {
                await ctx.Channel.SendMessageAsync(@$"https://youtube.com/shorts/zA_M92dKgfg?feature=share TOP G!").ConfigureAwait(false);
            }
            [Command("blah")]
            public async Task Joke(CommandContext ctx)
            {
                await ctx.Channel.SendMessageAsync($"Blah yourself. {ctx.User.Mention}").ConfigureAwait(false);


            }
            [Command("joke")]
            public async Task Blah(CommandContext ctx)
            {
                Random random = new Random();
                int a = random.Next(1, 11);

                switch (a)
                {
                    case 1:
                        await ctx.Channel.SendMessageAsync($"Q. Why couldn’t Jonah trust the ocean?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. Because he knew there was something fishy about it.").ConfigureAwait(false);
                        break;
                    case 2:
                        await ctx.Channel.SendMessageAsync("Q. What did Adam say when he was asked his favorite holiday?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. It's Christmas, Eve.").ConfigureAwait(false);
                        break;
                    case 3:
                        await ctx.Channel.SendMessageAsync("Q. What was Moses' wife, Zipphora, known as when she'd throw dinner parties?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. The hostess with the Moses.").ConfigureAwait(false);
                        break;
                    case 4:
                        await ctx.Channel.SendMessageAsync("Q. What did pirates call Noah's boat?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. The arrrrrrk.").ConfigureAwait(false);
                        break;
                    case 5:
                        await ctx.Channel.SendMessageAsync("Q. How does Moses make his coffee?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A.  Hebrews it.").ConfigureAwait(false);
                        break;
                    case 6:
                        await ctx.Channel.SendMessageAsync("Q. Why didn't Noah go fishing?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. He only had two worms.").ConfigureAwait(false);
                        break;
                    case 7:
                        await ctx.Channel.SendMessageAsync("Q. Why did the sponge go to church?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. It was hole-y.").ConfigureAwait(false);
                        break;
                    case 8:
                        await ctx.Channel.SendMessageAsync("Q. What is the best way to study the Bible?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. You Luke into it.").ConfigureAwait(false);
                        break;
                    case 9:
                        await ctx.Channel.SendMessageAsync("Q. What did God do to cure Moses' headache?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. He gave him two tablets.").ConfigureAwait(false);
                        break;
                    case 10:
                        await ctx.Channel.SendMessageAsync("Q. Where is the best place to get an ice cream cone?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. Sunday School.").ConfigureAwait(false);
                        break;
                    case 11:
                        await ctx.Channel.SendMessageAsync("Q. What is a mathematician's favorite book of the Bible?").ConfigureAwait(false);
                        await ctx.Channel.SendMessageAsync("A. Numbers.").ConfigureAwait(false);
                        break;



                    default:
                        await ctx.Channel.SendMessageAsync("yuck").ConfigureAwait(false);
                        break;

                }
            }
            [Command("Youcute")]
            public async Task Youcute(CommandContext ctx)
            {
                await ctx.Channel.SendMessageAsync("Thanks!! so are you, " + ctx.User.Mention + "!").ConfigureAwait(false);
            }

            [Command("mimic")]
            public async Task Text(CommandContext ctx, params string[] a)
            {
                await ctx.Channel.SendMessageAsync(ctx.Message.Content.ToString().Substring(6)).ConfigureAwait(false);

            }
            [Command("Add")]
            public async Task Addition(CommandContext ctx, int a, int b)
            {
                int c = a + b;
                await ctx.Channel.SendMessageAsync(c + "").ConfigureAwait(false);


            }
            [Command("power")]
            public async Task Power(CommandContext ctx, int a, int b)
            {
                double pow_ab = Math.Pow(a, b);
                await ctx.Channel.SendMessageAsync(pow_ab + "").ConfigureAwait(false);
            }
            [Command("sqrt")]
            public async Task Sqrt(CommandContext ctx, double a)
            {
                double sqrt = Math.Sqrt(a);
                await ctx.Channel.SendMessageAsync(sqrt + "").ConfigureAwait(false);
            }
            [Command("AreaC")]
            public async Task Areac(CommandContext ctx, int a)
            {
                double areaC = Math.PI * (a * a);
                await ctx.Channel.SendMessageAsync($"The area of the circle is: {areaC}.").ConfigureAwait(false);
            }
            [Command("sus")]
            public async Task Sus(CommandContext ctx)
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username}:face_with_raised_eyebrow: :camera_with_flash: Is detecting SUS behaviour. Please keep things cordual in the {ctx.Channel.Name} Channel.").ConfigureAwait(false);
            }
            [Command("msg[].")]
            public async Task MsgIDPeriod(CommandContext ctx, params string[] a)
            {
                int i = 0;
                foreach (var item in a)
                {


                    await ctx.Channel.SendMessageAsync($"{i + 1}. {a[i]}").ConfigureAwait(false);
                    i++;

                }


            }
            [Command("msg[]")]
            public async Task MsgID(CommandContext ctx, params string[] a)
            {
                int i = 0;
                foreach (var item in a)
                {


                    await ctx.Channel.SendMessageAsync($"{a[i]}").ConfigureAwait(false);
                    i++;

                }
            }
            [Command("botpic")]
            public async Task BotPic(CommandContext ctx)
            {
                await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/avatars/999096081126277190/18ecad2b2c2f9022184f8576007e1c22.png?size=2048").ConfigureAwait(false);
            }
            [Command("bruh")]
            public async Task Bruh(CommandContext ctx, int a)
            {
                for (int i = 1; i <= a && i <= 5; i++)
                {
                    await ctx.Channel.SendMessageAsync($"bruh").ConfigureAwait(false);
                }
                
            }
            [Command("bruh")]
            public async Task Bruh(CommandContext ctx)
            {
                    await ctx.Channel.SendMessageAsync($"bruh").ConfigureAwait(false);


            }
            [Command("motivate")]
            public async Task tatewisdom(CommandContext ctx)
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Mention} The five people you spend the most time with, that's what you're going to end up like. There has to be a point where you sit and go, okay, you're my friends, I love you guys, but I'm on a different life path. You have to leave some people behind. If you were to come hang out with me, and you were in a room with me and my five friends, you'd feel self conscious. I'm with killers, we're fucking monsters! and that self consciousness would motivate you or certainly instill the discipline required for you to change. You don't feel self conscious amongst your peers, that's why you don't change. If you were to be in a room and the were the only person who ain't a fucking monster, you'd want to become a monster. That's life, that's humanity. ~Andrew Tate\nhttps://youtube.com/shorts/aB9-DufM_JQ?feature=share").ConfigureAwait(false);


            }
            [Hidden]
            [Command("setactivity")]
            private async Task setactivity(CommandContext ctx)
            {
                if (ctx.User.Id == 239845658448625674)
                {
                    DiscordActivity activity = new DiscordActivity();
                    DiscordClient discord = ctx.Client;
                    string input = "With Websites";
                    activity.Name = input;
                    await discord.UpdateStatusAsync(activity);
                    return;
                }
                else
                {
                    return;
                }
            }
            [Command("minecraft")]
            public async Task minecraft(CommandContext ctx)
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Mention} The Minecraft server ip is: 99.242.41.227:25565").ConfigureAwait(false);


            }

            [Command("Post")]
            public async Task Post(CommandContext ctx, string a, string b)
            {
                Pushing(ctx, a,b);
                Console.WriteLine($"\n{ctx.User.Username} Has initiated the POST command with:\nPost name: {a}.\nContents: {b}");
                static async void Pushing(CommandContext ctx, string a, string b)
                {
                    MongoClient dbClient = new MongoClient("mongodb+srv://Gordon:gordo@csharpdb.llf1lah.mongodb.net/?retryWrites=true&w=majority");
                    Console.WriteLine("Successfully connected to MongoDB");

                    IMongoDatabase db = dbClient.GetDatabase("test");

                    var blogsConnect = db.GetCollection<BsonDocument>("blogs");


                    Blogs blogs = new Blogs();
                    blogs.Blogheader = a;
                    blogs.Blogpost = b;

                    var doc = new BsonDocument
                    {
                        {"blogheader", $"{blogs.Blogheader}" },
                        {"blogpost",$"{blogs.Blogpost}" }
                    };


                    Console.WriteLine(doc);
                    blogsConnect.InsertOne(doc);


                    var postEmbed = new DiscordEmbedBuilder
                    {
                        Title = $"{ctx.User.Username} Your Post Is Successful",
                        Description = "Your post and its contents have been successfully published.",
                        Url = "http://www.itsaok.engineer/about",
                        Color = DiscordColor.Violet,
                        
                    };
                    var button = new DiscordLinkButtonComponent("http://www.itsaok.engineer/about", "Check Your Post Here!");
                    var message = new DiscordMessageBuilder().AddEmbed(embed: postEmbed).AddComponents(button);

                    await ctx.Channel.SendMessageAsync(builder: message).ConfigureAwait(false);
                }
            }

            [Command("Cleanup")]
            public async Task Cleanup(CommandContext ctx)
            {
                Deletion();
                Console.WriteLine($"\n{ctx.User.Username} Has initiated the CLEANUP command.\n");
                var message = new DiscordMessageBuilder().WithContent($"{ctx.User.Username} Has Reset The Site");
                await ctx.Channel.SendMessageAsync(builder: message).ConfigureAwait(false);
                static async void Deletion()
                {
                    MongoClient dbClient = new MongoClient("mongodb+srv://Gordon:gordo@csharpdb.llf1lah.mongodb.net/?retryWrites=true&w=majority");
                    Console.WriteLine("Successfully connected to MongoDB");

                    IMongoDatabase db = dbClient.GetDatabase("test");

                    var blogsConnect = db.GetCollection<BsonDocument>("blogs");

                    db.DropCollection("blogs");
                    Console.WriteLine("Collection Dropped. . .");
                    db.CreateCollection("blogs");
                    Console.WriteLine("Collection Created. . .");


                }
            }

            [Command("Delete")]
            public async Task Delete(CommandContext ctx, string a)
            {
                DeleteByName(a);
                var message = new DiscordMessageBuilder().WithContent($"Post: {a}\nHas been deleted.");
                Console.WriteLine($"\n{ctx.User.Username} Has initiated the DELETE command on post {a}\n" );
                await ctx.Channel.SendMessageAsync(builder: message).ConfigureAwait(false);
                static async void DeleteByName(string a)
                {
                    MongoClient dbClient = new MongoClient("mongodb+srv://Gordon:gordo@csharpdb.llf1lah.mongodb.net/?retryWrites=true&w=majority");
                    Console.WriteLine("Successfully connected to MongoDB");

                    IMongoDatabase db = dbClient.GetDatabase("test");

                    var blogsConnect = db.GetCollection<BsonDocument>("blogs");

                    var filter = Builders<BsonDocument>.Filter.Eq("blogheader", a);

                    blogsConnect.DeleteOne(filter);


                }
            }
            [Command("Text")]
            public async Task Text(CommandContext ctx, string to, string body)
            {
                #region
                string accountSid = "AC08c7576b4620e3f0e7f595befd7b10c3";
                string authToken = "4cdbaef6815e16121de3df83349eb7e5";
                #endregion

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: body,
                    from: new Twilio.Types.PhoneNumber("+18656720691"),
                    to: new Twilio.Types.PhoneNumber($"+1{to}")
                );

                Console.WriteLine(message.Sid);
                Console.WriteLine(message.From);
                var textEmbed = new DiscordEmbedBuilder
                {
                    Title = $"{ctx.User.Username} Your Text has been successfully placed to: {to}",
                    Description = $"With the content: {body}",
                    Color = DiscordColor.CornflowerBlue
                };

                var textmessage = new DiscordMessageBuilder().AddEmbed(embed: textEmbed);
                await ctx.Channel.SendMessageAsync(builder: textmessage).ConfigureAwait(false);

                Console.WriteLine($"\n{ctx.User.Username} initiated the Text command.\nTo:{to}\nWith the contents of: {body}");

                await Task.Delay(10000);
                Console.WriteLine(message.Status);
            }
            [Command("Call")]
            public async Task Call(CommandContext ctx,string to, string say)
            {
                #region
                string accountSid = "AC08c7576b4620e3f0e7f595befd7b10c3";
                string authToken = "4cdbaef6815e16121de3df83349eb7e5";
                #endregion
                TwilioClient.Init(accountSid, authToken);

                var outgoingCallerId = OutgoingCallerIdResource.Fetch(
                     pathSid: "AC08c7576b4620e3f0e7f595befd7b10c3"
                );


                Console.WriteLine(outgoingCallerId.FriendlyName);

                var call = CallResource.Create(
                twiml: new Twilio.Types.Twiml($"<Response><Say>{say}</Say></Response>"),
                    from: new Twilio.Types.PhoneNumber("+18656720691"),
                    to: new Twilio.Types.PhoneNumber($"+1{to}")
                );
               
                Console.WriteLine(call.Sid);


                var callEmbed = new DiscordEmbedBuilder
                {
                    Title = $"{ctx.User.Username} Your Call has been successfully placed to: {to}",
                    Description = $"With the content: {say}",
                    Color = DiscordColor.Red

                };
                var message = new DiscordMessageBuilder().AddEmbed(embed: callEmbed);

                await ctx.Channel.SendMessageAsync(builder: message).ConfigureAwait(false);

                Console.WriteLine($"\n{ctx.User.Username} initiated the Call command.\nTo:{to}\nWith the contents of: {say}");
            }
        }
    }
}


