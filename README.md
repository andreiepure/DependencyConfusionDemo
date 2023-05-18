# Dependency Confusion Demo

Repository containg the demos I've used in the the following talks:
- [DotNet Iasi meetup](https://www.meetup.com/dotnetiasi/events/287271942/) on the 10th of August 2022
- .NET Day Switzerland on the 30th of August 2022 ([slides](https://speakerdeck.com/dotnetday/dot-net-day-22-dependency-confusion-and-its-cure-a-nuget-story-by-andrei-epure))
- VisugXL Belgium on the 28th of October 2022
- .NET User Group Geneva on the 8th of December 2022
- Techorama Belgium on the 17th of May 2023 ([slides](slides/EPURE_Techorama_2023.pdf))

Feel free to use this repository to demo in your company or team on how Dependency Confusion works.

And please don't forget to mention me when doing so :).

Thanks.

You can find how to defend your NuGet supply chain against dependency confusion on my blog: [.NET Day Switzerland resources](https://andreiepure.ro/2022/08/28/dotnetday-resources.html).

TL;DR the minimum:
1. (consumer) Use Package Source Mapping
1. (consumer) Use `<trusted signers>`
1. (publisher) Reserve prefixes for both your public and private packages on nuget.org

Extra mile:
1. (consumer) Use a NuGet lock file
1. (consumer) Only used fixed versions of your dependencies
1. (publisher) Sign your packages
1. (publisher) Use deterministic builds
