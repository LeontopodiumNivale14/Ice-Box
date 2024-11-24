namespace IceBox.Util;

public static class Data
{
    //This is the current cap of items on Island Sanctuary Items, just so I can quickly pull it at all times
    public const int MaxItems = 999;
    
    // List of all the Island Sanctuary Items ID's, organized in the order they pop up in the menu
    public const int PalmLeafID = 37551;
    public const int BranchID = 37553;
    public const int StoneID = 37554;
    public const int ClamID = 37555;
    public const int LaverID = 37556;
    public const int CoralID = 37557;
    public const int IslewortID = 37558;
    public const int SandID = 37559;
    public const int VineID = 37562;
    public const int SapID = 37563;
    public const int AppleID = 37552;
    public const int LogID = 37560;
    public const int PalmLogID = 37561;
    public const int CopperID = 37564;
    public const int LimestoneID = 37565;
    public const int RockSaltID = 37566;
    public const int ClayID = 37570;
    public const int TinsandID = 37571;
    public const int SugarcaneID = 37567;
    public const int CottonID = 37568;
    public const int HempID = 37569;
    public const int IslefishID = 37575;
    public const int SquidID = 37576;
    public const int JellyfishID = 37577;
    public const int IronOreID = 37572;
    public const int QuartzID = 37573;
    public const int LeucograniteID = 37574;
    public const int MulticoloredIslebloomsID = 39228;
    public const int ResinID = 39224;
    public const int CoconutID = 39225;
    public const int BeehiveID = 39226;
    public const int WoodOpalID = 39227;
    public const int CoalID = 39887;
    public const int GlimshroomID = 39889;
    public const int EffervescentWaterID = 39892;
    public const int ShaleID = 39888;
    public const int MarbleID = 39890;
    public const int MythrilOreID = 39888;
    public const int SpectrineID = 39893;
    public const int DuriumSandID = 41630;
    public const int YellowCopperOreID = 41631;
    public const int GoldOreID = 41632;
    public const int HawksEyeSandID = 41633;
    public const int CrystalFormationID = 41634;
    
    // Gets the current amount of the island sanctuary item that you have
    public static readonly int PalmLeafAmount = Utils.GetItemCount(PalmLeafID);
    public static readonly int BranchAmount = Utils.GetItemCount(BranchID);
    public static readonly int StoneAmount = Utils.GetItemCount(StoneID);
    public static readonly int ClamAmount = Utils.GetItemCount(ClamID);
    public static readonly int LaverAmount = Utils.GetItemCount(LaverID);
    public static readonly int CoralAmount = Utils.GetItemCount(CoralID); 
    public static readonly int IslewortAmount = Utils.GetItemCount(IslewortID);
    public static readonly int SandAmount = Utils.GetItemCount(SandID);
    public static readonly int VineAmount = Utils.GetItemCount(VineID);
    public static readonly int SapAmount = Utils.GetItemCount(SapID);
    public static readonly int AppleAmount = Utils.GetItemCount(AppleID);
    public static readonly int LogAmount = Utils.GetItemCount(LogID);
    public static readonly int PalmLogAmount = Utils.GetItemCount(PalmLogID);
    public static readonly int CopperAmount = Utils.GetItemCount(CopperID);
    public static readonly int LimestoneAmount = Utils.GetItemCount(LimestoneID);
    public static readonly int RockSaltAmount = Utils.GetItemCount(RockSaltID);
    public static readonly int ClayAmount = Utils.GetItemCount(ClayID);
    public static readonly int TinsandAmount = Utils.GetItemCount(TinsandID);
    public static readonly int SugarcaneAmount = Utils.GetItemCount(SugarcaneID);
    public static readonly int CottonAmount = Utils.GetItemCount(CottonID);
    public static readonly int HempAmount = Utils.GetItemCount(HempID);
    public static readonly int IslefishAmount = Utils.GetItemCount(IslefishID);
    public static readonly int SquAmountAmount = Utils.GetItemCount(SquidID);
    public static readonly int JellyfishAmount = Utils.GetItemCount(JellyfishID);
    public static readonly int IronOreAmount = Utils.GetItemCount(IronOreID);
    public static readonly int QuartzAmount = Utils.GetItemCount(QuartzID);
    public static readonly int LeucograniteAmount = Utils.GetItemCount(LeucograniteID);
    public static readonly int MulticoloredIslebloomsAmount = Utils.GetItemCount(MulticoloredIslebloomsID);
    public static readonly int ResinAmount = Utils.GetItemCount(ResinID);
    public static readonly int CoconutAmount = Utils.GetItemCount(CoconutID);
    public static readonly int BeehiveAmount = Utils.GetItemCount(BeehiveID);
    public static readonly int WoodOpalAmount = Utils.GetItemCount(WoodOpalID);
    public static readonly int CoalAmount = Utils.GetItemCount(CoalID);
    public static readonly int GlimshroomAmount = Utils.GetItemCount(GlimshroomID);
    public static readonly int EffervescentWaterAmount = Utils.GetItemCount(EffervescentWaterID);
    public static readonly int ShaleAmount = Utils.GetItemCount(ShaleID);
    public static readonly int MarbleAmount = Utils.GetItemCount(MarbleID);
    public static readonly int MythrilOreAmount = Utils.GetItemCount(MythrilOreID);
    public static readonly int SpectrineAmount = Utils.GetItemCount(SpectrineID);
    public static readonly int DuriumSandAmount = Utils.GetItemCount(DuriumSandID);
    public static readonly int YellowCopperOreAmount = Utils.GetItemCount(YellowCopperOreID);
    public static readonly int GoldOreAmount = Utils.GetItemCount(GoldOreID);
    public static readonly int HawksEyeSandAmount = Utils.GetItemCount(HawksEyeSandID);
    public static readonly int CrystalFormationAmount = Utils.GetItemCount(CrystalFormationID);
    
    // Workshop amounts that will be sliders/customizable per player (or grabbed automatically, one/maybe both)
    public static int PalmLeafWorkshop { get; set; }
    public static int BranchWorkshop { get; set; }
    public static int StoneWorkshop { get; set; }
    public static int ClamWorkshop { get; set; }
    public static int LaverWorkshop { get; set; }
    public static int CoralWorkshop { get; set; }
    public static int IslewortWorkshop { get; set; }
    public static int SandWorkshop { get; set; }
    public static int VineWorkshop { get; set; }
    public static int SapWorkshop { get; set; }
    public static int AppleWorkshop { get; set; }
    public static int LogWorkshop { get; set; }
    public static int PalmLogWorkshop { get; set; }
    public static int CopperWorkshop { get; set; }
    public static int LimestoneWorkshop { get; set; }
    public static int RockSaltWorkshop { get; set; }
    public static int ClayWorkshop { get; set; }
    public static int TinsandWorkshop { get; set; }
    public static int SugarcaneWorkshop { get; set; }
    public static int CottonWorkshop { get; set; }
    public static int HempWorkshop { get; set; }
    public static int IslefishWorkshop { get; set; }
    public static int SquWorkshop { get; set; }
    public static int JellyfishWorkshop { get; set; }
    public static int IronOreWorkshop { get; set; }
    public static int QuartzWorkshop { get; set; }
    public static int LeucograniteWorkshop { get; set; }
    public static int MulticoloredIslebloomsWorkshop { get; set; }
    public static int ResinWorkshop { get; set; }
    public static int CoconutWorkshop { get; set; }
    public static int BeehiveWorkshop { get; set; }
    public static int WoodOpalWorkshop { get; set; }
    public static int CoalWorkshop { get; set; }
    public static int GlimshroomWorkshop { get; set; }
    public static int EffervescentWaterWorkshop { get; set; }
    public static int ShaleWorkshop { get; set; }
    public static int MarbleWorkshop { get; set; }
    public static int MythrilOreWorkshop { get; set; }
    public static int SpectrineWorkshop { get; set; }
    public static int DuriumSandWorkshop { get; set; }
    public static int YellowCopperOreWorkshop { get; set; }
    public static int GoldOreWorkshop { get; set; }
    public static int HawksEyeSandWorkshop { get; set; }
    public static int CrystalFormationWorkshop { get; set; }
    
    // Send Amounts (to be grabbed for the tables)
    public static int PalmLeafSend { get; set; }
    public static int BranchSend { get; set; }
    public static int StoneSend { get; set; }
    public static int ClamSend { get; set; }
    public static int LaverSend { get; set; }
    public static int CoralSend { get; set; }
    public static int IslewortSend { get; set; }
    public static int SandSend { get; set; }
    public static int VineSend { get; set; }
    public static int SapSend { get; set; }
    public static int AppleSend { get; set; }
    public static int LogSend { get; set; }
    public static int PalmLogSend { get; set; }
    public static int CopperSend { get; set; }
    public static int LimestoneSend { get; set; }
    public static int RockSaltSend { get; set; }
    public static int ClaySend { get; set; }
    public static int TinsandSend { get; set; }
    public static int SugarcaneSend { get; set; }
    public static int CottonSend { get; set; }
    public static int HempSend { get; set; }
    public static int IslefishSend { get; set; }
    public static int SquSend { get; set; }
    public static int JellyfishSend { get; set; }
    public static int IronOreSend { get; set; }
    public static int QuartzSend { get; set; }
    public static int LeucograniteSend { get; set; }
    public static int MulticoloredIslebloomsSend { get; set; }
    public static int ResinSend { get; set; }
    public static int CoconutSend { get; set; }
    public static int BeehiveSend { get; set; }
    public static int WoodOpalSend { get; set; }
    public static int CoalSend { get; set; }
    public static int GlimshroomSend { get; set; }
    public static int EffervescentWaterSend { get; set; }
    public static int ShaleSend { get; set; }
    public static int MarbleSend { get; set; }
    public static int MythrilOreSend { get; set; }
    public static int SpectrineSend { get; set; }
    public static int DuriumSandSend { get; set; }
    public static int YellowCopperOreSend { get; set; }
    public static int GoldOreSend { get; set; }
    public static int HawksEyeSandSend { get; set; }
    public static int CrystalFormationSend { get; set; }
    
    // Sell Amounts (to be grabbed for the tables)
    public static int PalmLeafSell { get; set; }
    public static int BranchSell { get; set; }
    public static int StoneSell { get; set; }
    public static int ClamSell { get; set; }
    public static int LaverSell { get; set; }
    public static int CoralSell { get; set; }
    public static int IslewortSell { get; set; }
    public static int SandSell { get; set; }
    public static int VineSell { get; set; }
    public static int SapSell { get; set; }
    public static int AppleSell { get; set; }
    public static int LogSell { get; set; }
    public static int PalmLogSell { get; set; }
    public static int CopperSell { get; set; }
    public static int LimestoneSell { get; set; }
    public static int RockSaltSell { get; set; }
    public static int ClaySell { get; set; }
    public static int TinsandSell { get; set; }
    public static int SugarcaneSell { get; set; }
    public static int CottonSell { get; set; }
    public static int HempSell { get; set; }
    public static int IslefishSell { get; set; }
    public static int SquSell { get; set; }
    public static int JellyfishSell { get; set; }
    public static int IronOreSell { get; set; }
    public static int QuartzSell { get; set; }
    public static int LeucograniteSell { get; set; }
    public static int MulticoloredIslebloomsSell { get; set; }
    public static int ResinSell { get; set; }
    public static int CoconutSell { get; set; }
    public static int BeehiveSell { get; set; }
    public static int WoodOpalSell { get; set; }
    public static int CoalSell { get; set; }
    public static int GlimshroomSell { get; set; }
    public static int EffervescentWaterSell { get; set; }
    public static int ShaleSell { get; set; }
    public static int MarbleSell { get; set; }
    public static int MythrilOreSell { get; set; }
    public static int SpectrineSell { get; set; }
    public static int DuriumSandSell { get; set; }
    public static int YellowCopperOreSell { get; set; }
    public static int GoldOreSell { get; set; }
    public static int HawksEyeSandSell { get; set; }
    public static int CrystalFormationSell { get; set; }
    
    
    // Route Loop Amounts
    public static int Route1Amount { get; set; }
    public static int Route2Amount { get; set; }
    

    public static int[,] Route1Table = new[,]
    {
        { 6, QuartzID, QuartzAmount, QuartzWorkshop, QuartzSend, QuartzSell, 0, 25, Route1Amount},
        { 3, IronOreID, IronOreAmount, IronOreWorkshop, IronOreSend, IronOreSell, 0, 24, Route1Amount},
        { 3, DuriumSandID, DuriumSandAmount, DuriumSandWorkshop, DuriumSandSend, DuriumSandSell, 0, 39, Route1Amount},
        { 2, LeucograniteID, LeucograniteAmount, LeucograniteWorkshop, LeucograniteSend, LeucograniteSell, 0, 26, Route1Amount},
        { 11, StoneID, StoneAmount, StoneWorkshop, StoneSend, StoneSell, 1, 2, Route1Amount}
    };

    public static int[,] Route2Table = new[,]
    {
        { 7, ClayID, ClayAmount, ClayWorkshop, ClaySend, ClaySell, 0},
        { 2, TinsandID, TinsandAmount, TinsandWorkshop, TinsandSend, TinsandSell, 0},
        { 1, MarbleID, MarbleAmount, MarbleWorkshop, MarbleSend, MarbleSell, 0},
        { 1, LimestoneID, LimestoneAmount, LimestoneWorkshop, LimestoneSend, LimestoneSell, 0},
        { 1, BranchID, BranchAmount, BranchWorkshop, BranchSend, BranchSell, 0},
        { 1, LogID, LogAmount, LogWorkshop, LogSend, LogSell, 0},
        { 1, ResinID, ResinAmount, ResinWorkshop, ResinSend, ResinSell, 0},
        { 10, SandID, SandAmount, SandWorkshop, SandSend, SandSell, 1},
    };
}



