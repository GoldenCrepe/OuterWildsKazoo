using System.Reflection;
using System.Threading;
using System.Timers;
using HarmonyLib;
using JetBrains.Annotations;
using Mono.Cecil.Cil;
using OWML.Common;
using OWML.ModHelper;
using Steamworks;
using Tessellation;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Tilemaps;

namespace OuterWildsKazoo
{
    public class OuterWildsKazoo : ModBehaviour
    {
        public static OuterWildsKazoo Instance;
        public AudioClip endCredits;
        public AudioClip flashbackSlam;
        public AudioClip flashbackLoop;
        public AudioClip flashbackOverlay1;
        public AudioClip flashbackLoopOverlay;
        public AudioClip flashbackOverlay;
        public AudioClip flashbackStingerDelayed;
        public AudioClip flashbackStinger;
        public AudioClip flashbackBase;
        public AudioClip sadTheme;
        public AudioClip skypeLP;
        public AudioClip vesselDiscovery;
        public AudioClip poolEnter;
        public AudioClip poolExit;
        public AudioClip eyeOfTheUniverse;
        public AudioClip darkBramble;
        public AudioClip endTimes;
        public AudioClip endTimesMuted;
        public AudioClip finalEndTimesDBLoop;
        public AudioClip finalEndTimesLoop1;
        public AudioClip finalEndTimesLoop2;
        public AudioClip giantsDeep;
        public AudioClip letThereBeLight;
        public AudioClip mainMenu;
        public AudioClip terribleFate;
        public AudioClip morning;
        public AudioClip nomaiRuins;
        public AudioClip nomaiRuinsMotif1c;
        public AudioClip nomaiRuinsMotif2c;
        public AudioClip nomaiRuinsMotif3c;
        public AudioClip nomaiRuinsMotif4c;
        public AudioClip nomaiRuinsMotif5c;
        public AudioClip nomaiRuinsMotif6c;
        public AudioClip nomaiRuinsMotif7c;
        public AudioClip space;
        public AudioClip atp;
        public AudioClip museum;
        public AudioClip nomaiCity;
        public AudioClip theSearch;
        public AudioClip sunStation;
        public AudioClip eyeOfTheUniverse2;
        public AudioClip quantumMoon;
        public AudioClip quantumSignal;
        public AudioClip timberHearth;
        public AudioClip travelerBanjo;
        public AudioClip travelerDrums;
        public AudioClip travelerFlute;
        public AudioClip travelerHarmonica;
        public AudioClip travelerPiano;
        public AudioClip travelerWhistling;
        public AudioClip travelerThemeNoPiano;
        public AudioClip travelerTheme;
        public AudioClip hideAndSeek;
        public AudioClip distressBeacon;
        public AudioClip banjoStrum1b;
        public AudioClip banjoStrum2b;
        public AudioClip banjoStrum3b;
        public AudioClip banjoStrum4b;
        public AudioClip interloper;
        public AudioClip scout;
        public AudioClip ancientGlade;

        private void Awake()
        {
            Instance = this;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
        private void Start()
        {
            endCredits = ModHelper.Assets.GetAudio("assets/OW End Credits 022019_3 AP.mp3");
            flashbackSlam = ModHelper.Assets.GetAudio("assets/OW NM Flashback 081718 AP slam.mp3");
            flashbackLoop = ModHelper.Assets.GetAudio("assets/OW NM Flashback 082818 AP loop.mp3");
            flashbackOverlay1 = ModHelper.Assets.GetAudio("assets/OW NM Flashback 082818 AP overlay1.mp3");
            flashbackLoopOverlay = ModHelper.Assets.GetAudio("assets/OW NM Flashback 082818 loop overlay AP.mp3");
            flashbackStingerDelayed = ModHelper.Assets.GetAudio("assets/OW NM Flashback 082818_2 AP stinger delayed.mp3");
            flashbackStinger = ModHelper.Assets.GetAudio("assets/OW NM Flashback 082818_2 AP stinger.mp3");
            flashbackBase = ModHelper.Assets.GetAudio("assets/OW NM Flashback 082818_3 AP base.mp3");
            sadTheme = ModHelper.Assets.GetAudio("assets/OW_NM_SadTheme_older.mp3");
            skypeLP = ModHelper.Assets.GetAudio("assets/OW_NM_SkypeLP.mp3");
            vesselDiscovery = ModHelper.Assets.GetAudio("assets/OW_NM_VesselDiscovery.mp3");
            poolEnter = ModHelper.Assets.GetAudio("assets/Pool_Enter_v3_Fade.mp3");
            poolExit = ModHelper.Assets.GetAudio("assets/Pool_Exit_v3.mp3");
            eyeOfTheUniverse = ModHelper.Assets.GetAudio("assets/OW Eye Of The Universe 082018_2 AP.mp3");
            darkBramble = ModHelper.Assets.GetAudio("assets/OW_DarkBramble_loop.mp3");
            endTimes = ModHelper.Assets.GetAudio("assets/OW_EndTimes.mp3");
            endTimesMuted = ModHelper.Assets.GetAudio("assets/OW Muted End Times 040821 AP.mp3");
            finalEndTimesDBLoop = ModHelper.Assets.GetAudio("assets/OW_FinalEndTimes_DB_loop.mp3");
            finalEndTimesLoop1 = ModHelper.Assets.GetAudio("assets/OW Final End Times 022519_2 AP LOOP1.mp3");
            finalEndTimesLoop2 = ModHelper.Assets.GetAudio("assets/OW Final End Times 022519_2 AP LOOP2.mp3");
            giantsDeep = ModHelper.Assets.GetAudio("assets/OW Aquatic Exploration 050318 AP LOOP.mp3");
            letThereBeLight = ModHelper.Assets.GetAudio("assets/OW END OF GAME 021818 AP.mp3");
            mainMenu = ModHelper.Assets.GetAudio("assets/OW_Main_Menu.mp3");
            terribleFate = ModHelper.Assets.GetAudio("assets/ow_kazoo_theme.mp3");
            morning = ModHelper.Assets.GetAudio("assets/OW Morning Cello 101718_2.mp3");
            nomaiRuins = ModHelper.Assets.GetAudio("assets/OW NM Nomai Ruins 081718 AP.mp3");
            nomaiRuinsMotif1c = ModHelper.Assets.GetAudio("assets/OW NomaiRuinsRegular 081918 AP motif1c.mp3");
            nomaiRuinsMotif2c = ModHelper.Assets.GetAudio("assets/OW NomaiRuinsRegular 081918 AP motif2c.mp3");
            nomaiRuinsMotif3c = ModHelper.Assets.GetAudio("assets/OW NomaiRuinsRegular 081918 AP motif3c v2.mp3");
            nomaiRuinsMotif4c = ModHelper.Assets.GetAudio("assets/OW NomaiRuinsRegular 081918 AP motif4c.mp3");
            nomaiRuinsMotif5c = ModHelper.Assets.GetAudio("assets/OW NomaiRuinsRegular 081918 AP motif5c v2.mp3");
            nomaiRuinsMotif6c = ModHelper.Assets.GetAudio("assets/OW NomaiRuinsRegular 081918 AP motif6c.mp3");
            nomaiRuinsMotif7c = ModHelper.Assets.GetAudio("assets/OW NomaiRuinsRegular 081918 AP motif7c.mp3");
            space = ModHelper.Assets.GetAudio("assets/OW_Travel_Theme_Remaster.mp3");
            atp = ModHelper.Assets.GetAudio("assets/OW Nomai Time Loop Device 081818 AP.mp3");
            museum = ModHelper.Assets.GetAudio("assets/OW_TH_Museum.mp3");
            nomaiCity = ModHelper.Assets.GetAudio("assets/OW NM Nomai City 081718 AP LOOP.mp3");
            theSearch = ModHelper.Assets.GetAudio("assets/OW_NM_Tech_Advanced.mp3");
            sunStation = ModHelper.Assets.GetAudio("assets/OW_NM_SunStation.mp3");
            eyeOfTheUniverse2 = ModHelper.Assets.GetAudio("assets/OW Eye Of The Universe 082818_2 AP.mp3");
            quantumMoon = ModHelper.Assets.GetAudio("assets/OW_QuantumMoon.mp3");
            quantumSignal = ModHelper.Assets.GetAudio("assets/OW_QuantumSignal.mp3");
            timberHearth = ModHelper.Assets.GetAudio("assets/Hearth Village.mp3");
            travelerBanjo = ModHelper.Assets.GetAudio("assets/OW_TravelerTheme_banjo.mp3");
            travelerDrums = ModHelper.Assets.GetAudio("assets/OW_TravelerTheme_drums.mp3");
            travelerFlute = ModHelper.Assets.GetAudio("assets/OW_TravelerTheme_flute.mp3");
            travelerHarmonica = ModHelper.Assets.GetAudio("assets/OW_TravelerTheme_harmonica.mp3");
            travelerPiano = ModHelper.Assets.GetAudio("assets/OW_TravelerTheme_piano.mp3");
            travelerWhistling = ModHelper.Assets.GetAudio("assets/OW_TravelerTheme_whistling.mp3");
            travelerThemeNoPiano = ModHelper.Assets.GetAudio("assets/OW Traveler Theme 091118 AP FINAL TIME NO PIANO EDIT.mp3");
            travelerTheme = ModHelper.Assets.GetAudio("assets/OW Traveler Theme 091118 AP FINAL TIME WITH PIANO EDIT.mp3");
            hideAndSeek = ModHelper.Assets.GetAudio("assets/CampfireTune_All_Reverb.mp3");
            distressBeacon = ModHelper.Assets.GetAudio("assets/OW_NM_EscapePodDistressSignal.mp3");
            banjoStrum1b = ModHelper.Assets.GetAudio("assets/OW_PR_BanjoStrum_1b.mp3");
            banjoStrum2b = ModHelper.Assets.GetAudio("assets/OW_PR_BanjoStrum_2b.mp3");
            banjoStrum3b = ModHelper.Assets.GetAudio("assets/OW_PR_BanjoStrum_3b.mp3");
            banjoStrum4b = ModHelper.Assets.GetAudio("assets/OW_PR_BanjoStrum_4b.mp3");
            interloper = ModHelper.Assets.GetAudio("assets/Ice_Cave_Amb_loop_v3_01.mp3");
            scout = ModHelper.Assets.GetAudio("assets/OW_PR_ProbeInAirSound.mp3");
            ancientGlade = ModHelper.Assets.GetAudio("assets/Ancient Glade.mp3");

            GameObject.FindWithTag("Global").GetComponent<AudioManager>().LoadAllAudioData();
            ModHelper.Console.WriteLine($"{nameof(OuterWildsKazoo)} is loaded. God save your ears.", MessageType.Success);
        }
    }
    [HarmonyPatch]
    public class BugFixer3000
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(AudioManager), nameof(AudioManager.LoadAllAudioData))]
        public static void WeDoBeLoadingAudioTho(AudioManager __instance)
        {
            // audio
            var audioTable = __instance._audioLibraryDict;

            // template because i am stupid and will have to bring up the code hundreds of times
            // audioTable[(int)AudioType.InGameFileName] = new AudioLibrary.AudioEntry(AudioType.InGameFileName, new[] { NewFileVar });
            audioTable[(int)AudioType.FinalCredits] = new AudioLibrary.AudioEntry(AudioType.FinalCredits, new[] { OuterWildsKazoo.Instance.endCredits });
            audioTable[(int)AudioType.MemoryUplink_Start] = new AudioLibrary.AudioEntry(AudioType.MemoryUplink_Start, new[] { OuterWildsKazoo.Instance.flashbackSlam });
            audioTable[(int)AudioType.MemoryUplink_LP] = new AudioLibrary.AudioEntry(AudioType.MemoryUplink_LP, new[] { OuterWildsKazoo.Instance.flashbackLoop });
            audioTable[(int)AudioType.Flashback_Overlay_1_LP] = new AudioLibrary.AudioEntry(AudioType.Flashback_Overlay_1_LP, new[] { OuterWildsKazoo.Instance.flashbackOverlay1 });
            audioTable[(int)AudioType.MemoryUplink_Overlay_LP] = new AudioLibrary.AudioEntry(AudioType.MemoryUplink_Overlay_LP, new[] { OuterWildsKazoo.Instance.flashbackLoopOverlay });
            audioTable[(int)AudioType.MemoryUplink_End] = new AudioLibrary.AudioEntry(AudioType.MemoryUplink_End, new[] { OuterWildsKazoo.Instance.flashbackStingerDelayed });
            audioTable[(int)AudioType.Flashback_End] = new AudioLibrary.AudioEntry(AudioType.Flashback_End, new[] { OuterWildsKazoo.Instance.flashbackStinger });
            audioTable[(int)AudioType.Flashback_Base_LP] = new AudioLibrary.AudioEntry(AudioType.Flashback_Base_LP, new[] { OuterWildsKazoo.Instance.flashbackBase });
            audioTable[(int)AudioType.SadNomaiTheme] = new AudioLibrary.AudioEntry(AudioType.SadNomaiTheme, new[] { OuterWildsKazoo.Instance.sadTheme });
            audioTable[(int)AudioType.NomaiRemoteCameraAmbient_LP] = new AudioLibrary.AudioEntry(AudioType.NomaiRemoteCameraAmbient_LP, new[] { OuterWildsKazoo.Instance.skypeLP });
            audioTable[(int)AudioType.DB_VesselDiscovery] = new AudioLibrary.AudioEntry(AudioType.DB_VesselDiscovery, new[] { OuterWildsKazoo.Instance.vesselDiscovery });
            audioTable[(int)AudioType.NomaiRemoteCameraEntry] = new AudioLibrary.AudioEntry(AudioType.NomaiRemoteCameraEntry, new[] { OuterWildsKazoo.Instance.poolEnter });
            audioTable[(int)AudioType.NomaiRemoteCameraExit] = new AudioLibrary.AudioEntry(AudioType.NomaiRemoteCameraExit, new[] { OuterWildsKazoo.Instance.poolExit });
            audioTable[(int)AudioType.EyeShuttleFlight] = new AudioLibrary.AudioEntry(AudioType.EyeShuttleFlight, new[] { OuterWildsKazoo.Instance.eyeOfTheUniverse });
            audioTable[(int)AudioType.DB_Ambient] = new AudioLibrary.AudioEntry(AudioType.DB_Ambient, new[] { OuterWildsKazoo.Instance.darkBramble });
            audioTable[(int)AudioType.EndOfTime] = new AudioLibrary.AudioEntry(AudioType.EndOfTime, new[] { OuterWildsKazoo.Instance.endTimes });
            audioTable[(int)AudioType.EndOfTime_Dream] = new AudioLibrary.AudioEntry(AudioType.EndOfTime_Dream, new[] { OuterWildsKazoo.Instance.endTimesMuted });
            audioTable[(int)AudioType.EndOfTime_DBFinal] = new AudioLibrary.AudioEntry(AudioType.EndOfTime_DBFinal, new[] { OuterWildsKazoo.Instance.finalEndTimesDBLoop });
            audioTable[(int)AudioType.EndOfTime_Final] = new AudioLibrary.AudioEntry(AudioType.EndOfTime_Final, new[] { OuterWildsKazoo.Instance.finalEndTimesLoop1 });
            audioTable[(int)AudioType.EndOfTime_Final_LP] = new AudioLibrary.AudioEntry(AudioType.EndOfTime_Final_LP, new[] { OuterWildsKazoo.Instance.finalEndTimesLoop2 });
            audioTable[(int)AudioType.GD_UnderwaterExploration] = new AudioLibrary.AudioEntry(AudioType.GD_UnderwaterExploration, new[] { OuterWildsKazoo.Instance.giantsDeep });
            audioTable[(int)AudioType.EYE_EndOfGame] = new AudioLibrary.AudioEntry(AudioType.EYE_EndOfGame, new[] { OuterWildsKazoo.Instance.letThereBeLight });
            audioTable[(int)AudioType.MainMenuTheme] = new AudioLibrary.AudioEntry(AudioType.MainMenuTheme, new[] { OuterWildsKazoo.Instance.mainMenu });
            audioTable[(int)AudioType.KazooTheme] = new AudioLibrary.AudioEntry(AudioType.KazooTheme, new[] { OuterWildsKazoo.Instance.terribleFate });
            audioTable[(int)AudioType.PostCredits] = new AudioLibrary.AudioEntry(AudioType.PostCredits, new[] { OuterWildsKazoo.Instance.morning });
            audioTable[(int)AudioType.NomaiRuinsBaseTrack] = new AudioLibrary.AudioEntry(AudioType.NomaiRuinsBaseTrack, new[] { OuterWildsKazoo.Instance.nomaiRuins });
            audioTable[(int)AudioType.NomaiRuinsOverlayTracks] = new AudioLibrary.AudioEntry(AudioType.NomaiRuinsOverlayTracks, new[] { OuterWildsKazoo.Instance.nomaiRuinsMotif1c, OuterWildsKazoo.Instance.nomaiRuinsMotif2c, OuterWildsKazoo.Instance.nomaiRuinsMotif3c, OuterWildsKazoo.Instance.nomaiRuinsMotif4c, OuterWildsKazoo.Instance.nomaiRuinsMotif5c, OuterWildsKazoo.Instance.nomaiRuinsMotif6c, OuterWildsKazoo.Instance.nomaiRuinsMotif7c });
            audioTable[(int)AudioType.Travel_Theme] = new AudioLibrary.AudioEntry(AudioType.Travel_Theme, new[] { OuterWildsKazoo.Instance.space });
            audioTable[(int)AudioType.TimeLoopDevice_Ambient] = new AudioLibrary.AudioEntry(AudioType.TimeLoopDevice_Ambient, new[] { OuterWildsKazoo.Instance.atp });
            audioTable[(int)AudioType.TH_Observatory] = new AudioLibrary.AudioEntry(AudioType.TH_Observatory, new[] { OuterWildsKazoo.Instance.museum });
            audioTable[(int)AudioType.HT_City] = new AudioLibrary.AudioEntry(AudioType.HT_City, new[] { OuterWildsKazoo.Instance.nomaiCity });
            audioTable[(int)AudioType.BH_Observatory] = new AudioLibrary.AudioEntry(AudioType.BH_Observatory, new[] { OuterWildsKazoo.Instance.theSearch });
            audioTable[(int)AudioType.SunStation] = new AudioLibrary.AudioEntry(AudioType.SunStation, new[] { OuterWildsKazoo.Instance.sunStation });
            audioTable[(int)AudioType.EYE_QuantumFoamApproach] = new AudioLibrary.AudioEntry(AudioType.EYE_QuantumFoamApproach, new[] { OuterWildsKazoo.Instance.eyeOfTheUniverse2 });
            audioTable[(int)AudioType.QM_Ambient] = new AudioLibrary.AudioEntry(AudioType.QM_Ambient, new[] { OuterWildsKazoo.Instance.quantumMoon });
            audioTable[(int)AudioType.QuantumAmbience_LP] = new AudioLibrary.AudioEntry(AudioType.QuantumAmbience_LP, new[] { OuterWildsKazoo.Instance.quantumSignal });
            audioTable[(int)AudioType.TH_Village] = new AudioLibrary.AudioEntry(AudioType.TH_Village, new[] { OuterWildsKazoo.Instance.timberHearth });
            audioTable[(int)AudioType.TravelerRiebeck] = new AudioLibrary.AudioEntry(AudioType.TravelerRiebeck, new[] { OuterWildsKazoo.Instance.travelerBanjo });
            audioTable[(int)AudioType.TravelerChert] = new AudioLibrary.AudioEntry(AudioType.TravelerChert, new[] { OuterWildsKazoo.Instance.travelerDrums });
            audioTable[(int)AudioType.TravelerGabbro] = new AudioLibrary.AudioEntry(AudioType.TravelerGabbro, new[] { OuterWildsKazoo.Instance.travelerFlute });
            audioTable[(int)AudioType.TravelerFeldspar] = new AudioLibrary.AudioEntry(AudioType.TravelerFeldspar, new[] { OuterWildsKazoo.Instance.travelerHarmonica });
            audioTable[(int)AudioType.TravelerNomai] = new AudioLibrary.AudioEntry(AudioType.TravelerNomai, new[] { OuterWildsKazoo.Instance.travelerPiano });
            audioTable[(int)AudioType.TravelerEsker] = new AudioLibrary.AudioEntry(AudioType.TravelerEsker, new[] { OuterWildsKazoo.Instance.travelerWhistling });
            audioTable[(int)AudioType.TravelerEnd_NoPiano] = new AudioLibrary.AudioEntry(AudioType.TravelerEnd_NoPiano, new[] { OuterWildsKazoo.Instance.travelerThemeNoPiano });
            audioTable[(int)AudioType.TravelerEnd_All] = new AudioLibrary.AudioEntry(AudioType.TravelerEnd_All, new[] { OuterWildsKazoo.Instance.travelerTheme });
            audioTable[(int)AudioType.ToolScopeHideAndSeekSignal] = new AudioLibrary.AudioEntry(AudioType.ToolScopeHideAndSeekSignal, new[] { OuterWildsKazoo.Instance.hideAndSeek });
            audioTable[(int)AudioType.NomaiEscapePodDistressSignal_LP] = new AudioLibrary.AudioEntry(AudioType.NomaiEscapePodDistressSignal_LP, new[] { OuterWildsKazoo.Instance.distressBeacon });
            audioTable[(int)AudioType.TH_BanjoTuning] = new AudioLibrary.AudioEntry(AudioType.TH_BanjoTuning, new[] { OuterWildsKazoo.Instance.banjoStrum1b, OuterWildsKazoo.Instance.banjoStrum2b, OuterWildsKazoo.Instance.banjoStrum3b, OuterWildsKazoo.Instance.banjoStrum4b });
            audioTable[(int)AudioType.CometAmbience_LP] = new AudioLibrary.AudioEntry(AudioType.CometAmbience_LP, new[] { OuterWildsKazoo.Instance.interloper });
            audioTable[(int)AudioType.ToolProbeFlight_LP] = new AudioLibrary.AudioEntry(AudioType.ToolProbeFlight_LP, new[] { OuterWildsKazoo.Instance.scout });
            audioTable[(int)AudioType.EYE_ForestOfGalaxies] = new AudioLibrary.AudioEntry(AudioType.EYE_ForestOfGalaxies, new[] { OuterWildsKazoo.Instance.ancientGlade });
        }
    }
}
/*        saving for later :)    
             private void Viontelligence()
{
    Viontelligence();
    LoadManager.OnCompleteSceneLoad += (_, loadScene) =>
    {
        Viontelligence();
    };
    */   