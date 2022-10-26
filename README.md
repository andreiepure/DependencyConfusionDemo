# Dependency Confusion Demo

Repository containg the demos I've used in the the following talks:
- [DotNet Iasi meetup](https://www.meetup.com/dotnetiasi/events/287271942/) on the 10th of August 2022
- .NET Day Switzerland on the 30th of August 2022
- VisugXL Belgium on the 28th of October 2022

Beware of the [Evil_Hacker](https://www.nuget.org/packages/Corporate.Private.Library/1.0.9999)!

Feel free to use this repository to demo in your company or team on how Dependency Confusion works.

And please don't forget to mention me when doing so :).

Thanks.

Checkout the following tags for each demo:
- `demo0` for typosquatting with `Gogle.Protobuf`
- `demo1` for public version of private package `Corporate.Private.Library`
- `demo2` for Package Source Mapping defense for hybrid package source configurations
- `demo3` for `<trustedSigners>` defense for typosquatting and owners updates
- `demo4` for `packages.lock.json` - notice when an unexpected version is used (and the hash of the package)

You can find how to defend your NuGet supply chain against dependency confusion on my blog:
- [VisugXL resources](https://andreiepure.ro/2022/10/26/visugxl-resources.html)
- [.NET Day Switzerland resources](https://andreiepure.ro/2022/08/28/dotnetday-resources.html)

TL;DR the minimum:
1. (consumer) Use Package Source Mapping
1. (consumer) Use `<trusted signers>`
1. (publisher) Reserve prefixes for both your public and private packages on nuget.org

Extra mile:
1. (consumer) Use a NuGet lock file
1. (consumer) Only used fixed versions of your dependencies
1. (publisher) Sign your packages
1. (publisher) Use deterministic builds
