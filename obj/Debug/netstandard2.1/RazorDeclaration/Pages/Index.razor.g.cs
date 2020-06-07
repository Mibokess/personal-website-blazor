#pragma checksum "C:\Users\Mike\dev\personal-website-blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8945e6bde6a727b03efb0caa66f1fea44c646db"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace personal_website.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using personal_website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using personal_website.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mike\dev\personal-website-blazor\Pages\Index.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mike\dev\personal-website-blazor\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mike\dev\personal-website-blazor\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mike\dev\personal-website-blazor\Pages\Index.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Mike\dev\personal-website-blazor\Pages\Index.razor"
       
    List<TimelineEvent> Events = readEventsFromFile();

    static List<TimelineEvent> readEventsFromFile() 
    {
        var events = JsonSerializer.Deserialize<List<TimelineEvent>>(jsonString);
        var eventsWithYears = new List<TimelineEvent>(events.Count);

        eventsWithYears.Add(new TimelineEvent("1/1/" + events[0].Date.Year));

        for (int i = 0; i < events.Count - 1; i++)
        {
            eventsWithYears.Add(events[i]);
            
            if (events[i].Date.Year != events[i + 1].Date.Year) 
            {
                eventsWithYears.Add(new TimelineEvent("1/1/" + events[i].Date.Year));
            }
        }

        eventsWithYears.Add(events[events.Count - 1]);
        eventsWithYears.Add(new TimelineEvent("1/1/" + events[events.Count - 1].Date.Year));

        return eventsWithYears;
    }

    static string jsonString = 
    @"[
        { ""title"": ""Spring Semester 2019"", ""description"": ""6th Semester"", ""children"": [
                { 
                    ""title"": ""Introduction to machine learning"", 
                    ""description"": ""8 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2019""
                },
                { 
                    ""title"": ""Information security"", 
                    ""description"": ""8 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2019""
                },
                { 
                    ""title"": ""Bachelor Thesis"", 
                    ""description"": ""10 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2019""
                }
            ], 
            ""date"": ""2/1/2019""
        },
        { 
            ""title"": ""Autumn Semester 2018"", 
            ""description"": ""5th Semester & teaching assistant"", 
            ""children"": [
                { 
                    ""title"": ""Computer systems"", 
                    ""description"": ""8 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Algorithms, probability and computing"", 
                    ""description"": ""8 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Visual computing"", 
                    ""description"": ""8 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Software Engineering Seminar"", 
                    ""description"": ""2 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Diskrete Ereignissysteme"", 
                    ""description"": ""5 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Japanese A1.1"", 
                    ""description"": ""3 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Teaching Assistant"", 
                    ""description"": ""Einführung in die Programmierung"", 
                    ""children"": [
                        { 
                            ""title"": """", 
                            ""description"": ""Supervision of a group of first Semester students in coordination with a second assistant for the subject \""Introduction to Programming\"" during the autumn Semester. Tasks included the explaining of unclear material, exercises and the correction thereof including feedback."", 
                            ""children"": [],
                            ""date"": ""2/1/2018""
                        }
                    ],
                    ""date"": ""2/1/2018""
                }
            ], 
            ""date"": ""2/1/2018""
        },
        { 
            ""title"": ""Cerebral Zürich Camp"", 
            ""description"": ""Civil service - 2 weeks"", 
            ""children"": [
                { 
                    ""title"": """", 
                    ""description"": ""One-to-one care for two disabled holiday guests in Cerebral Zürich Summer camp, one week each. The care included everything from morning to evening."", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                }
            ], 
            ""date"": ""2/1/2018""
        },
        { 
            ""title"": ""Spring Semester 2018"", 
            ""description"": ""4th Semester & teaching assistant"", 
            ""children"": [
                { 
                    ""title"": ""Computer Networks"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Formal methods and functional programming"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Databases and data modeling"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Wahrscheinlichkeit und Statistik"", 
                    ""description"": ""5 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Information retrieval"", 
                    ""description"": ""4 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Introduction to game theory"", 
                    ""description"": ""3 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2018""
                },
                { 
                    ""title"": ""Teaching Assistant"", 
                    ""description"": ""Parallel Programming"", 
                    ""children"": [
                        { 
                            ""title"": """", 
                            ""description"": ""Supervision of a group of students (15 to 20) in their second Semester for the subject \""Parallel Programming\"". Attendance of the didactic training course for teaching assistants."", 
                            ""children"": [],
                            ""date"": ""2/1/2018""
                        }
                    ],
                    ""date"": ""2/1/2018""
                }
            ], 
            ""date"": ""2/1/2018""
        },
        { 
            ""title"": ""Autumn Semester 2017"", 
            ""description"": ""3th Semester"", 
            ""children"": [
                { 
                    ""title"": ""Systems Programming and Computer Architecture"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2017""
                },
                { 
                    ""title"": ""Numerical Methods for CSE"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2017""
                },
                { 
                    ""title"": ""Theoretische Informatik"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2017""
                },
                { 
                    ""title"": ""Analysis 2"", 
                    ""description"": ""5 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2017""
                },
                { 
                    ""title"": ""Human Computer Interaction"", 
                    ""description"": ""3 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2017""
                }
            ], 
            ""date"": ""2/1/2017""
        },
        { 
            ""title"": ""Spring Semester 2017"", 
            ""description"": ""2th Semester"", 
            ""children"": [
                { 
                    ""title"": ""Analysis 1"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2017""
                },
                { 
                    ""title"": ""Algorithmen und Wahrscheinlichkeit"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2017""
                },
                { 
                    ""title"": ""Parallel Programming"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2017""
                },
                {
                    ""title"": ""Design of Digital Circuits"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2017""
                }
            ], 
            ""date"": ""2/1/2017""
        },
        { 
            ""title"": ""Autumn Semester 2016"", 
            ""description"": ""1th Semester"", 
            ""children"": [
                { 
                    ""title"": ""Diskrete Mathematik"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2016""
                },
                { 
                    ""title"": ""Lineare Algebra"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2016""
                },
                { 
                    ""title"": ""Einführung in die Programmierung"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2016""
                },
                { 
                    ""title"": ""Algorithmen und Datenstrukturen"", 
                    ""description"": ""7 credit points"", 
                    ""children"": [],
                    ""date"": ""2/1/2016""
                }
            ], 
            ""date"": ""2/1/2016""
        },
        { 
            ""title"": ""SIX GROUP Stamford"", 
            ""description"": ""Internship - 3 weeks"", 
            ""children"": [
                { 
                    ""title"": """", 
                    ""description"": ""Largely a learning experience exploring the activities of the IT department as well as its interactions with other departments as well as additional administrative tasks in the IT area."", 
                    ""children"": [],
                    ""date"": ""2/1/2015""
                }
            ], 
            ""date"": ""2/1/2015""
        },
        { 
            ""title"": ""Beginning of Existence"", 
            ""description"": ""The simultation had not yet begun; only after the godly words were spoken \""Deploy it already, it's friday afternoon!\"" there was light!"", 
            ""children"": [], 
            ""date"": ""2/1/1998""
        }
    ]";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591