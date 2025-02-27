using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Lexicon
{
    public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static List<string> ThreeLetter_A = new List<string>()
    {
        "AAH", "AAL", "AAS", "ABA", "ABS", "ABY", "ACE", "ACK", "ACT", "ADD", "ADO", "ADS", "ADZ", "AFF", "AFT", "AGA", "AGE", "AGO", "AGS", "AHA", "AHI", "AHS",
        "AID", "AIL", "AIM", "AIN", "AIR", "AIS", "AIT", "AJI", "ALA", "ALB", "ALE", "ALL", "ALP", "ALS", "ALT", "AMA", "AMI", "AMP", "AMU", "ANA", "AND", "ANE",
        "ANI", "ANT", "ANY", "APE", "APO", "APP", "APT", "ARB", "ARC", "ARE", "ARF", "ARK", "ARM", "ARO", "ARS", "ART", "ASH", "ASK", "ASP", "ASS", "ATE", "ATS",
        "ATT", "AUK", "AVA", "AVE", "AVO", "AWA", "AWE", "AWL", "AWN", "AXE", "AYE", "AYS", "AZO"
    };
    public static List<string> ThreeLetter_B = new List<string>()
    {
        "BAA", "BAD", "BAE", "BAG", "BAH", "BAL", "BAM", "BAN", "BAP", "BAR", "BAS", "BAT", "BAY", "BED", "BEE", "BEG", "BEL", "BEN", "BES", "BET", "BEY", "BIB",
        "BID", "BIG", "BIN", "BIO", "BIS", "BIT", "BIZ", "BOA", "BOB", "BOD", "BOG", "BOO", "BOP", "BOS", "BOT", "BOW", "BOX", "BOY", "BRA", "BRO", "BRR", "BUB",
        "BUD", "BUG", "BUM", "BUN", "BUR", "BUS", "BUT", "BUY", "BYE", "BYS"
    };
    public static List<string> ThreeLetter_C = new List<string>()
    {
        "CAB", "CAD", "CAF", "CAM", "CAN", "CAP", "CAR", "CAT", "CAW", "CAY", "CEE", "CEL", "CEP", "CHI", "CIG", "CIS", "COB", "COD", "COG", "COL", "CON", "COO",
        "COP", "COR", "COS", "COT", "COW", "COX", "COY", "COZ", "CRU", "CRY", "CUB", "CUD", "CUE", "CUM", "CUP", "CUR", "CUT", "CUZ", "CWM"
    };
    public static List<string> ThreeLetter_D = new List<string>()
    {
        "DAB", "DAD", "DAG", "DAH", "DAK", "DAL", "DAM", "DAN", "DAP", "DAS", "DAW", "DAY", "DEB", "DEE", "DEF", "DEL", "DEN", "DEP", "DEV", "DEW", "DEX", "DEY",
        "DIB", "DID", "DIE", "DIF", "DIG", "DIM", "DIN", "DIP", "DIS", "DIT", "DOC", "DOE", "DOG", "DOH", "DOL", "DOM", "DON", "DOR", "DOS", "DOT", "DOW", "DOX",
        "DRY", "DUB", "DUD", "DUE", "DUG", "DUH", "DUI", "DUM", "DUN", "DUO", "DUP", "DYE"
    };
    public static List<string> ThreeLetter_E = new List<string>()
    {
        "EAR", "EAT", "EAU", "EBB", "ECO", "ECU", "EDH", "EDS", "EEK", "EEL", "EEW", "EFF", "EFS", "EFT", "EGG", "EGO", "EKE", "ELD", "ELF", "ELK", "ELL", "ELM",
        "ELS", "EME", "EMO", "EMS", "EMU", "END", "ENG", "ENS", "EON", "ERA", "ERE", "ERG", "ERN", "ERR", "ERS", "ESS", "EST", "ETA", "ETH", "EVE", "EWE", "EYE"
    };
    public static List<string> ThreeLetter_F = new List<string>()
    {
        "FAB", "FAD", "FAH", "FAM", "FAN", "FAR", "FAS", "FAT", "FAV", "FAX", "FAY", "FED", "FEE", "FEH", "FEN", "FER", "FES", "FET", "FEU", "FEW", "FEY", "FEZ",
        "FIB", "FID", "FIE", "FIG", "FIL", "FIN", "FIR", "FIT", "FIX", "FIZ", "FLU", "FLY", "FOB", "FOE", "FOG", "FOH", "FON", "FOO", "FOP", "FOR", "FOU", "FOX",
        "FOY", "FRO", "FRY", "FUB", "FUD", "FUG", "FUN", "FUR"
    };
    public static List<string> ThreeLetter_G = new List<string>()
    {
        "GAB", "GAD", "GAE", "GAG", "GAL", "GAM", "GAN", "GAP", "GAR", "GAS", "GAT", "GAY", "GED", "GEE", "GEL", "GEM", "GEN", "GET", "GEY", "GHI", "GIB", "GID",
        "GIE", "GIF", "GIG", "GIN", "GIS", "GIT", "GNU", "GOA", "GOB", "GOD", "GOO", "GOR", "GOS", "GOT", "GOX", "GRR", "GUL", "GUM", "GUN", "GUT", "GUV", "GUY",
        "GYM"
    };
    public static List<string> ThreeLetter_H = new List<string>()
    {
        "HAD", "HAE", "HAG", "HAH", "HAJ", "HAM", "HAO", "HAP", "HAS", "HAT", "HAW", "HAY", "HEH", "HEM", "HEN", "HEP", "HER", "HES", "HET", "HEW", "HEX", "HEY",
        "HIC", "HID", "HIE", "HIM", "HIN", "HIP", "HIS", "HIT", "HMM", "HOB", "HOD", "HOE", "HOG", "HOM", "HON", "HOO", "HOP", "HOT", "HOW", "HOY", "HUB", "HUE",
        "HUG", "HUH", "HUM", "HUN", "HUP", "HUT", "HYP"
    };
    public static List<string> ThreeLetter_I = new List<string>()
    {
        "ICE", "ICH", "ICK", "ICY", "IDS", "IFF", "IFS", "IGG", "ILK", "ILL", "IMP", "INK", "INN", "INS", "ION", "IRE", "IRK", "ISM", "ITS", "IVY"
    };
    public static List<string> ThreeLetter_J = new List<string>()
    {
        "JAB", "JAG", "JAM", "JAR", "JAW", "JAY", "JEE", "JET", "JEU", "JIB", "JIG", "JIN", "JOB", "JOE", "JOG", "JOT", "JOW", "JOY", "JUG", "JUN", "JUS", "JUT"
    };
    public static List<string> ThreeLetter_K = new List<string>()
    {
        "KAB", "KAE", "KAF", "KAS", "KAT", "KAY", "KEA", "KEF", "KEG", "KEN", "KEP", "KEX", "KEY", "KHI", "KID", "KIF", "KIN", "KIP", "KIR", "KIS", "KIT", "KOA",
        "KOB", "KOI", "KOP", "KOR", "KOS", "KUE", "KYE"
    };
    public static List<string> ThreeLetter_L = new List<string>()
    {
        "LAB", "LAC", "LAD", "LAG", "LAH", "LAM", "LAP", "LAR", "LAS", "LAT", "LAV", "LAW", "LAX", "LAY", "LEA", "LED", "LEE", "LEG", "LEI", "LEK", "LET", "LEU",
        "LEV", "LEX", "LEY", "LIB", "LID", "LIE", "LIN", "LIP", "LIS", "LIT", "LOB", "LOG", "LOO", "LOP", "LOT", "LOW", "LOX", "LUD", "LUG", "LUM", "LUN", "LUV",
        "LUX", "LYE"
    };
    public static List<string> ThreeLetter_M = new List<string>()
    {
        "MAC", "MAD", "MAE", "MAG", "MAM", "MAN", "MAP", "MAR", "MAS", "MAT", "MAW", "MAX", "MAY", "MED", "MEG", "MEH", "MEL", "MEM", "MEN", "MET", "MEW", "MHO",
        "MIB", "MIC", "MID", "MIG", "MIL", "MIM", "MIR", "MIS", "MIX", "MMM", "MOA", "MOB", "MOC", "MOD", "MOG", "MOI", "MOL", "MOM", "MON", "MOO", "MOP", "MOR",
        "MOS", "MOT", "MOW", "MUD", "MUG", "MUM", "MUN", "MUS", "MUT", "MUX", "MYC"
    };
    public static List<string> ThreeLetter_N = new List<string>()
    {
        "NAB", "NAE", "NAG", "NAH", "NAM", "NAN", "NAP", "NAV", "NAW", "NAY", "NEB", "NEE", "NEG", "NET", "NEW", "NIB", "NIL", "NIM", "NIP", "NIT", "NIX", "NOB",
        "NOD", "NOG", "NOH", "NOM", "NOO", "NOR", "NOS", "NOT", "NOW", "NTH", "NUB", "NUG", "NUN", "NUS", "NUT"
    };
    public static List<string> ThreeLetter_O = new List<string>()
    {
        "OAF", "OAK", "OAR", "OAT", "OBA", "OBE", "OBI", "OCA", "OCH", "ODA", "ODD", "ODE", "ODS", "OES", "OFF", "OFT", "OHM", "OHO", "OHS", "OIK", "OIL", "OKA",
        "OKE", "OLD", "OLE", "OMA", "OMS", "ONE", "ONO", "ONS", "OOF", "OOH", "OOT", "OPA", "OPE", "OPS", "OPT", "ORA", "ORB", "ORC", "ORE", "ORG", "ORS", "ORT",
        "OSE", "OUD", "OUR", "OUT", "OVA", "OWE", "OWL", "OWN", "OWT", "OXO", "OXY"
    };
    public static List<string> ThreeLetter_P = new List<string>()
    {
        "PAC", "PAD", "PAH", "PAK", "PAL", "PAM", "PAN", "PAP", "PAR", "PAS", "PAT", "PAW", "PAX", "PAY", "PEA", "PEC", "PED", "PEE", "PEG", "PEH", "PEN", "PEP",
        "PER", "PES", "PET", "PEW", "PHI", "PHO", "PHT", "PIA", "PIC", "PIE", "PIG", "PIN", "PIP", "PIS", "PIT", "PIU", "PIX", "PLY", "POD", "POH", "POI", "POL",
        "POM", "POO", "POP", "POS", "POT", "POW", "POX", "PRO", "PRY", "PSI", "PST", "PUB", "PUD", "PUG", "PUL", "PUN", "PUP", "PUR", "PUS", "PUT", "PYA", "PYE",
        "PYX"

    };
    public static List<string> ThreeLetter_Q = new List<string>()
    {
        "QAT", "QIS", "QUA"
    };
    public static List<string> ThreeLetter_R = new List<string>()
    {
        "RAD", "RAG", "RAH", "RAI", "RAJ", "RAM", "RAN", "RAP", "RAS", "RAT", "RAW", "RAX", "RAY", "REB", "REC", "RED", "REE", "REF", "REG", "REI", "REM", "REP",
        "RES", "RET", "REV", "REX", "REZ", "RHO", "RIA", "RIB", "RID", "RIF", "RIG", "RIM", "RIN", "RIP", "ROB", "ROC", "ROD", "ROE", "ROM", "ROO", "ROT", "ROW",
        "RUB", "RUE", "RUG", "RUM", "RUN", "RUT", "RYA", "RYE", "RYU"
    };
    public static List<string> ThreeLetter_S = new List<string>()
    {
        "SAB", "SAC", "SAD", "SAE", "SAG", "SAL", "SAN", "SAP", "SAT", "SAU", "SAW", "SAX", "SAY", "SEA", "SEC", "SEE", "SEI", "SEL", "SEN", "SER", "SET", "SEV",
        "SEW", "SEX", "SHA", "SHE", "SHH", "SHO", "SHY", "SIB", "SIC", "SIG", "SIM", "SIN", "SIP", "SIR", "SIS", "SIT", "SIX", "SKA", "SKI", "SKY", "SLY", "SOB",
        "SOC", "SOD", "SOH", "SOL", "SOM", "SON", "SOP", "SOS", "SOT", "SOU", "SOW", "SOX", "SOY", "SPA", "SPY", "SRI", "STY", "SUB", "SUE", "SUK", "SUM", "SUN",
        "SUP", "SUQ", "SUS", "SYN"
    };
    public static List<string> ThreeLetter_T = new List<string>()
    {
        "TAB", "TAD", "TAE", "TAG", "TAJ", "TAM", "TAN", "TAO", "TAP", "TAR", "TAS", "TAT", "TAU", "TAV", "TAW", "TAX", "TEA", "TEC", "TED", "TEE", "TEG", "TEL",
        "TEN", "TES", "TET", "TEW", "THE", "THO", "THY", "TIC", "TIE", "TIL", "TIN", "TIP", "TIS", "TIT", "TIX", "TIZ", "TOD", "TOE", "TOG", "TOM", "TON", "TOO",
        "TOP", "TOR", "TOT", "TOW", "TOY", "TRY", "TSK", "TUB", "TUG", "TUI", "TUM", "TUN", "TUP", "TUT", "TUX", "TWA", "TWO", "TYE"
    };
    public static List<string> ThreeLetter_U = new List<string>()
    {
        "UDO", "UGH", "UKE", "ULU", "UMM", "UMP", "UMS", "UNI", "UNS", "UPO", "UPS", "URB", "URD", "URN", "URP", "USE", "UTA", "UTE", "UTS"
    };
    public static List<string> ThreeLetter_V = new List<string>()
    {
        "VAC", "VAN", "VAR", "VAS", "VAT", "VAU", "VAV", "VAW", "VAX", "VEE", "VEG", "VET", "VEX", "VIA", "VID", "VIE", "VIG", "VIM", "VIN", "VIS", "VOE", "VOG",
        "VOW", "VOX", "VUG", "VUM"
    };
    public static List<string> ThreeLetter_W = new List<string>()
    {
        "WAB", "WAD", "WAE", "WAG", "WAN", "WAP", "WAR", "WAS", "WAT", "WAW", "WAX", "WAY", "WEB", "WED", "WEE", "WEN", "WET", "WHA", "WHO", "WHY", "WIG", "WIN",
        "WIS", "WIT", "WIZ", "WOE", "WOK", "WON", "WOO", "WOS", "WOT", "WOW", "WRY", "WUD", "WYE", "WYN"
    };
    public static List<string> ThreeLetter_X = new List<string>()
    {
        "XIS"
    };
    public static List<string> ThreeLetter_Y = new List<string>()
    {
        "YAG", "YAH", "YAK", "YAM", "YAP", "YAR", "YAS", "YAW", "YAY", "YEA", "YEH", "YEN", "YEP", "YES", "YET", "YEW", "YIN", "YIP", "YOB", "YOD", "YOK", "YOM",
        "YON", "YOU", "YOW", "YUK", "YUM", "YUP"
    };
    public static List<string> ThreeLetter_Z = new List<string>()
    {
        "ZAG", "ZAP", "ZAS", "ZAX", "ZED", "ZEE", "ZEK", "ZEN", "ZEP", "ZIG", "ZIN", "ZIP", "ZIT", "ZOA", "ZOO", "ZUZ", "ZZZ"
    };

    public static List<string> FourLetter_A = new List<string>()
    {
        "AAHS", "AALS", "ABAS", "ABBA", "ABBE", "ABED", "ABET", "ABLE", "ABLY", "ABOS", "ABRI", "ABUT", "ABYE", "ABYS", "ACED", "ACES", "ACHE", "ACHY", "ACID",
        "ACME", "ACNE", "ACRE", "ACTA", "ACTS", "ACYL", "ADDS", "ADIT", "ADOS", "ADZE", "AEON", "AERO", "AERY", "AFAR", "AGAR", "AGAS", "AGED", "AGEE", "AGER",
        "AGES", "AGHA", "AGIN", "AGIO", "AGLY", "AGMA", "AGOG", "AGON", "AGUE", "AHED", "AHEM", "AHIS", "AHOY", "AIDE", "AIDS", "AILS", "AIMS", "AINS", "AIRN",
        "AIRS", "AIRT", "AIRY", "AITS", "AJAR", "AJEE", "AKEE", "AKIN", "ALAE", "ALAN", "ALAR", "ALAS", "ALBA", "ALBS", "ALEC", "ALEE", "ALEF", "ALES", "ALFA",
        "ALGA", "ALIF", "ALIT", "ALKY", "ALLS", "ALLY", "ALMA", "ALME", "ALMS", "ALOE", "ALOW", "ALPS", "ALSO", "ALTO", "ALTS", "ALUM", "AMAH", "AMAS", "AMBO",
        "AMEN", "AMIA", "AMID", "AMIE", "AMIN", "AMIR", "AMIS", "AMMO", "AMOK", "AMPS", "AMUS", "AMYL", "ANAS", "ANDS", "ANES", "ANEW", "ANGA", "ANIL", "ANIS",
        "ANKH", "ANNA", "ANOA", "ANON", "ANSA", "ANTA", "ANTE", "ANTI", "ANTS", "APED", "APER", "APES", "APEX", "APOD", "APOS", "APPS", "APSE", "AQUA", "ARAK",
        "ARBS", "ARCH", "ARCO", "ARCS", "AREA", "ARES", "ARFS", "ARIA", "ARID", "ARIL", "ARKS", "ARMS", "ARMY", "ARTS", "ARTY", "ARUM", "ARVO", "ARYL", "ASCI",
        "ASEA", "ASHY", "ASKS", "ASPS", "ATAP", "ATES", "ATMA", "ATOM", "ATOP", "AUKS", "AULD", "AUNT", "AURA", "AUTO", "AVER", "AVES", "AVID", "AVOS", "AVOW",
        "AWAY", "AWED", "AWEE", "AWES", "AWLS", "AWNS", "AWNY", "AWOL", "AWRY", "AXAL", "AXED", "AXEL", "AXES", "AXIL", "AXIS", "AXLE", "AXON", "AYAH", "AYES",
        "AYIN", "AZAN", "AZON"
    };
    public static List<string> FourLetter_B = new List<string>()
    {
        "BAAL", "BAAS", "BABA", "BABE", "BABU", "BABY", "BACH", "BACK", "BADE", "BADS", "BAFF", "BAGS", "BAHT", "BAIL", "BAIT", "BAKE", "BALD", "BALE", "BALK",
        "BALL", "BALM", "BALS", "BAMS", "BAND", "BANE", "BANG", "BANI", "BANK", "BANS", "BAPS", "BARB", "BARD", "BARE", "BARF", "BARK", "BARM", "BARN", "BARS",
        "BASE", "BASH", "BASK", "BASS", "BAST", "BATE", "BATH", "BATS", "BATT", "BAUD", "BAWD", "BAWL", "BAYS", "BEAD", "BEAK", "BEAM", "BEAN", "BEAR", "BEAT",
        "BEAU", "BECK", "BEDS", "BEDU", "BEEF", "BEEN", "BEEP", "BEER", "BEES", "BEET", "BEGS", "BELL", "BELS", "BELT", "BEMA", "BEND", "BENE", "BENS", "BENT",
        "BERG", "BERK", "BERM", "BEST", "BETA", "BETH", "BETS", "BEVY", "BEYS", "BHUT", "BIAS", "BIBB", "BIBS", "BICE", "BIDE", "BIDI", "BIDS", "BIER", "BIFF",
        "BIGS", "BIKE", "BILE", "BILK", "BILL", "BIMA", "BIND", "BINE", "BINS", "BINT", "BIOG", "BIOS", "BIRD", "BIRK", "BIRL", "BIRO", "BIRR", "BISE", "BISK",
        "BITE", "BITS", "BITT", "BIZE", "BLAB", "BLAE", "BLAH", "BLAM", "BLAT", "BLAW", "BLEB", "BLED", "BLET", "BLEW", "BLIN", "BLIP", "BLOB", "BLOC", "BLOG",
        "BLOT", "BLOW", "BLUB", "BLUE", "BLUR", "BOAR", "BOAS", "BOAT", "BOBS", "BOCK", "BODE", "BODS", "BODY", "BOFF", "BOGS", "BOGY", "BOHO", "BOIL", "BOLA",
        "BOLD", "BOLE", "BOLL", "BOLO", "BOLT", "BOMB", "BOND", "BONE", "BONG", "BONK", "BONY", "BOOB", "BOOK", "BOOM", "BOON", "BOOR", "BOOS", "BOOT", "BOPS",
        "BORA", "BORE", "BORK", "BORN", "BORT", "BOSH", "BOSK", "BOSS", "BOTA", "BOTH", "BOTS", "BOTT", "BOUT", "BOWL", "BOWS", "BOXY", "BOYO", "BOYS", "BOZO",
        "BRAD", "BRAE", "BRAG", "BRAN", "BRAS", "BRAT", "BRAW", "BRAY", "BRED", "BREE", "BREN", "BREW", "BRIE", "BRIG", "BRIM", "BRIN", "BRIO", "BRIS", "BRIT",
        "BROO", "BROS", "BROW", "BRRR", "BRUT", "BRUX", "BUBO", "BUBS", "BUBU", "BUCK", "BUDS", "BUFF", "BUGS", "BUHL", "BUHR", "BULB", "BULK", "BULL", "BUMF",
        "BUMP", "BUMS", "BUNA", "BUND", "BUNG", "BUNK", "BUNN", "BUNS", "BUNT", "BUOY", "BURA", "BURB", "BURD", "BURG", "BURL", "BURN", "BURP", "BURR", "BURS",
        "BURY", "BUSH", "BUSK", "BUSS", "BUST", "BUSY", "BUTE", "BUTS", "BUTT", "BUYS", "BUZZ", "BYES", "BYRE", "BYRL", "BYTE"
    };
    public static List<string> FourLetter_C = new List<string>()
    {
        "CABS", "CACA", "CADE", "CADI", "CADS", "CAFE", "CAFF", "CAGE", "CAGY", "CAID", "CAIN", "CAKE", "CAKY", "CALF", "CALK", "CALL", "CALM", "CALO", "CALX",
        "CAME", "CAMO", "CAMP", "CAMS", "CANE", "CANS", "CANT", "CAPE", "CAPH", "CAPO", "CAPS", "CARB", "CARD", "CARE", "CARK", "CARL", "CARN", "CARP", "CARR",
        "CARS", "CART", "CASA", "CASE", "CASH", "CASK", "CAST", "CATE", "CATS", "CAUL", "CAVE", "CAVY", "CAWS", "CAYS", "CECA", "CEDE", "CEDI", "CEES", "CEIL",
        "CELL", "CELS", "CELT", "CENT", "CEPE", "CEPS", "CERE", "CERO", "CESS", "CETE", "CHAD", "CHAI", "CHAM", "CHAO", "CHAP", "CHAR", "CHAT", "CHAW", "CHAY",
        "CHEF", "CHEW", "CHEZ", "CHIA", "CHIC", "CHID", "CHIN", "CHIP", "CHIS", "CHIT", "CHON", "CHOP", "CHOW", "CHUB", "CHUG", "CHUM", "CIAO", "CIGS", "CINE",
        "CION", "CIRE", "CIST", "CITE", "CITY", "CLAD", "CLAG", "CLAM", "CLAN", "CLAP", "CLAW", "CLAY", "CLEF", "CLEW", "CLIP", "CLOD", "CLOG", "CLON", "CLOP",
        "CLOT", "CLOY", "CLUB", "CLUE", "COAL", "COAT", "COAX", "COBB", "COBS", "COCA", "COCO", "CODA", "CODE", "CODS", "COED", "COFF", "COFT", "COGS", "COHO",
        "COIF", "COIL", "COIN", "COIR", "COKE", "COKY", "COLA", "COLD", "COLE", "COLS", "COLT", "COLY", "COMA", "COMB", "COME", "COMP", "CONE", "CONI", "CONK",
        "CONN", "CONS", "CONY", "COOF", "COOK", "COOL", "COOP", "COOS", "COOT", "COPE", "COPS", "COPY", "CORD", "CORE", "CORF", "CORK", "CORM", "CORN", "CORS",
        "CORY", "COSH", "COSS", "COST", "COSY", "COTE", "COTS", "COUP", "COVE", "COWL", "COWS", "COWY", "COXA", "COYS", "COZY", "CRAB", "CRAG", "CRAM", "CRAW",
        "CRED", "CREW", "CRIB", "CRIS", "CRIT", "CROC", "CROP", "CROW", "CRUD", "CRUS", "CRUX", "CUBE", "CUBS", "CUDS", "CUED", "CUES", "CUFF", "CUIF", "CUKE",
        "CULL", "CULM", "CULT", "CUPS", "CURB", "CURD", "CURE", "CURF", "CURL", "CURN", "CURR", "CURS", "CURT", "CUSK", "CUSP", "CUSS", "CUTE", "CUTS", "CWMS",
        "CYAN", "CYMA", "CYME", "CYST", "CZAR"
    };
    public static List<string> FourLetter_D = new List<string>()
    {
        "DABS", "DACE", "DADA", "DADO", "DADS", "DAFF", "DAFT", "DAGO", "DAGS", "DAHL", "DAHS", "DAIS", "DAKS", "DALE", "DALS", "DAME", "DAMP", "DAMS", "DANG",
        "DANK", "DANS", "DAPS", "DARB", "DARE", "DARK", "DARN", "DART", "DASH", "DATA", "DATE", "DATO", "DAUB", "DAUT", "DAVY", "DAWK", "DAWN", "DAWS", "DAWT",
        "DAYS", "DAZE", "DEAD", "DEAF", "DEAL", "DEAN", "DEAR", "DEBS", "DEBT", "DECK", "DECO", "DEED", "DEEM", "DEEP", "DEER", "DEES", "DEET", "DEFI", "DEFT",
        "DEFY", "DEIL", "DEKE", "DELE", "DELF", "DELI", "DELL", "DELS", "DELT", "DEME", "DEMO", "DEMY", "DENE", "DENI", "DENS", "DENT", "DENY", "DERE", "DERM",
        "DESK", "DEVA", "DEVS", "DEWS", "DEWY", "DEXY", "DEYS", "DHAK", "DHAL", "DHOW", "DIAL", "DIBS", "DICE", "DIDO", "DIDY", "DIED", "DIEL", "DIES", "DIET",
        "DIFF", "DIFS", "DIGS", "DILL", "DIME", "DIMS", "DINE", "DING", "DINO", "DINS", "DINT", "DIOL", "DIPS", "DIPT", "DIRE", "DIRK", "DIRL", "DIRT", "DISC",
        "DISH", "DISK", "DISS", "DITA", "DITE", "DITS", "DITZ", "DIVA", "DIVE", "DJIN", "DOAT", "DOBY", "DOCK", "DOCS", "DODO", "DOER", "DOES", "DOFF", "DOGE",
        "DOGS", "DOGY", "DOIT", "DOJO", "DOLE", "DOLL", "DOLS", "DOLT", "DOME", "DOMS", "DONA", "DONE", "DONG", "DONS", "DOOM", "DOOR", "DOPA", "DOPE", "DOPY",
        "DORE", "DORK", "DORM", "DORP", "DORR", "DORS", "DORY", "DOSE", "DOSS", "DOST", "DOTE", "DOTH", "DOTS", "DOTY", "DOUM", "DOUR", "DOUX", "DOVE", "DOWN",
        "DOWS", "DOXY", "DOZE", "DOZY", "DRAB", "DRAG", "DRAM", "DRAT", "DRAW", "DRAY", "DREE", "DREG", "DREK", "DREW", "DRIB", "DRIP", "DROP", "DRUB", "DRUG",
        "DRUM", "DRYS", "DUAD", "DUAL", "DUBS", "DUCE", "DUCI", "DUCK", "DUCT", "DUDE", "DUDS", "DUEL", "DUES", "DUET", "DUFF", "DUGS", "DUIT", "DUKE", "DULL",
        "DULY", "DUMA", "DUMB", "DUMP", "DUNE", "DUNG", "DUNK", "DUNS", "DUNT", "DUOS", "DUPE", "DUPS", "DURA", "DURE", "DURN", "DURO", "DURR", "DUSK", "DUST",
        "DUTY", "DYAD", "DYED", "DYER", "DYES", "DYNE"
    };
    public static List<string> FourLetter_E = new List<string>()
    {
        "EACH", "EARL", "EARN", "EARS", "EASE", "EAST", "EASY", "EATH", "EATS", "EAUX", "EAVE", "EBBS", "EBON", "ECHE", "ECHO", "ECHT", "ECRU", "ECUS", "EDDO",
        "EDDY", "EDGE", "EDGY", "EDHS", "EDIT", "EELS", "EELY", "EERY", "EFFS", "EFTS", "EGAD", "EGAL", "EGER", "EGGS", "EGGY", "EGIS", "EGOS", "EIDE", "EKED",
        "EKES", "ELAN", "ELDS", "ELHI", "ELKS", "ELLS", "ELMS", "ELMY", "ELSE", "EMES", "EMEU", "EMIC", "EMIR", "EMIT", "EMMY", "EMUS", "EMYD", "ENDS", "ENGS",
        "ENOL", "ENOW", "ENUF", "ENVY", "EONS", "EPEE", "EPHA", "EPIC", "EPOS", "ERAS", "ERGO", "ERGS", "ERNE", "ERNS", "EROS", "ERRS", "ERST", "ESES", "ESNE",
        "ESPY", "ETAS", "ETCH", "ETHS", "ETIC", "ETNA", "ETUI", "EURO", "EVEN", "EVER", "EVES", "EVIL", "EWER", "EWES", "EXAM", "EXEC", "EXED", "EXES", "EXIT",
        "EXON", "EXPO", "EYAS", "EYED", "EYEN", "EYER", "EYES", "EYNE", "EYRA", "EYRE", "EYRY"
    };
    public static List<string> FourLetter_F = new List<string>()
    {
        "FABS", "FACE", "FACT", "FADE", "FADO", "FADS", "FAGS", "FAIL", "FAIN", "FAIR", "FAKE", "FALL", "FALX", "FAME", "FANE", "FANG", "FANO", "FANS", "FARD",
        "FARE", "FARL", "FARM", "FARO", "FASH", "FAST", "FATE", "FATS", "FAUN", "FAUX", "FAVA", "FAVE", "FAWN", "FAYS", "FAZE", "FEAL", "FEAR", "FEAT", "FECK",
        "FEDS", "FEEB", "FEED", "FEEL", "FEES", "FEET", "FEHS", "FELL", "FELT", "FEME", "FEMS", "FEND", "FENS", "FEOD", "FERE", "FERN", "FESS", "FEST", "FETA",
        "FETE", "FETS", "FEUD", "FEUS", "FIAR", "FIAT", "FIBS", "FICE", "FICO", "FIDO", "FIDS", "FIEF", "FIFE", "FIGS", "FILA", "FILE", "FILL", "FILM", "FILO",
        "FILS", "FIND", "FINE", "FINK", "FINO", "FINS", "FIRE", "FIRM", "FIRN", "FIRS", "FISC", "FISH", "FIST", "FITS", "FIVE", "FIXT", "FIZZ", "FLAB", "FLAG",
        "FLAK", "FLAM", "FLAN", "FLAP", "FLAT", "FLAW", "FLAX", "FLAY", "FLEA", "FLED", "FLEE", "FLEW", "FLEX", "FLEY", "FLIC", "FLIP", "FLIR", "FLIT", "FLOC",
        "FLOE", "FLOG", "FLOP", "FLOW", "FLUB", "FLUE", "FLUS", "FLUX", "FOAL", "FOAM", "FOBS", "FOCI", "FOES", "FOGS", "FOGY", "FOHN", "FOIL", "FOIN", "FOLD",
        "FOLK", "FOND", "FONS", "FONT", "FOOD", "FOOL", "FOOT", "FOPS", "FORA", "FORB", "FORD", "FORE", "FORK", "FORM", "FORT", "FOSS", "FOUL", "FOUR", "FOWL",
        "FOXY", "FOYS", "FOZY", "FRAE", "FRAG", "FRAP", "FRAT", "FRAY", "FREE", "FRET", "FRIG", "FRIT", "FRIZ", "FROE", "FROG", "FROM", "FROW", "FRUG", "FUBS",
        "FUCI", "FUDS", "FUEL", "FUGS", "FUGU", "FUJI", "FULL", "FUME", "FUMY", "FUND", "FUNK", "FUNS", "FURL", "FURS", "FURY", "FUSE", "FUSS", "FUTZ", "FUZE",
        "FUZZ", "FYCE", "FYKE"
    };
    public static List<string> FourLetter_G = new List<string>()
    {
        "GABS", "GABY", "GADI", "GADS", "GAED", "GAEN", "GAES", "GAFF", "GAGA", "GAGE", "GAGS", "GAIN", "GAIT", "GALA", "GALE", "GALL", "GALS", "GAMA", "GAMB",
        "GAME", "GAMP", "GAMS", "GAMY", "GANE", "GANG", "GAOL", "GAPE", "GAPS", "GAPY", "GARB", "GARS", "GASH", "GASP", "GAST", "GATE", "GATS", "GAUD", "GAUM",
        "GAUN", "GAUR", "GAVE", "GAWK", "GAWP", "GAYS", "GAZE", "GEAR", "GECK", "GEDS", "GEED", "GEEK", "GEES", "GEEZ", "GELD", "GELS", "GELT", "GEMS", "GENE",
        "GENS", "GENT", "GENU", "GERM", "GEST", "GETA", "GETS", "GEUM", "GHAT", "GHEE", "GHIS", "GIBE", "GIBS", "GIDS", "GIED", "GIEN", "GIES", "GIFT", "GIGA",
        "GIGS", "GILD", "GILL", "GILT", "GIMP", "GINK", "GINS", "GIPS", "GIRD", "GIRL", "GIRN", "GIRO", "GIRT", "GIST", "GITE", "GITS", "GIVE", "GLAD", "GLAM",
        "GLED", "GLEE", "GLEG", "GLEN", "GLEY", "GLIA", "GLIB", "GLIM", "GLOB", "GLOM", "GLOP", "GLOW", "GLUE", "GLUG", "GLUM", "GLUT", "GNAR", "GNAT", "GNAW",
        "GNUS", "GOAD", "GOAL", "GOAS", "GOAT", "GOBO", "GOBS", "GOBY", "GODS", "GOER", "GOES", "GOGO", "GOLD", "GOLF", "GONE", "GONG", "GOOD", "GOOF", "GOON",
        "GOOP", "GOOS", "GORE", "GORM", "GORP", "GORY", "GOSH", "GOTH", "GOUT", "GOWD", "GOWK", "GOWN", "GOYS", "GRAB", "GRAD", "GRAM", "GRAN", "GRAT", "GRAY",
        "GREE", "GREW", "GREY", "GRID", "GRIG", "GRIM", "GRIN", "GRIP", "GRIT", "GROG", "GROK", "GROT", "GROW", "GRUB", "GRUE", "GRUM", "GUAN", "GUAR", "GUCK",
        "GUDE", "GUFF", "GUID", "GULF", "GULL", "GULP", "GULS", "GUMS", "GUNK", "GUNS", "GURU", "GUSH", "GUST", "GUTS", "GUVS", "GUYS", "GYBE", "GYMS", "GYPS",
        "GYRE", "GYRI", "GYRO", "GYVE"
    };
    public static List<string> FourLetter_H = new List<string>()
    {
        "HAAF", "HAAR", "HABU", "HACK", "HADE", "HADJ", "HAED", "HAEM", "HAEN", "HAES", "HAET", "HAFT", "HAGS", "HAHA", "HAHS", "HAIK", "HAIL", "HAIR", "HAJI",
        "HAJJ", "HAKE", "HAKU", "HALE", "HALF", "HALL", "HALM", "HALO", "HALT", "HAME", "HAMS", "HAND", "HANG", "HANK", "HANT", "HAPS", "HARD", "HARE", "HARK",
        "HARL", "HARM", "HARP", "HART", "HASH", "HASP", "HAST", "HATE", "HATH", "HATS", "HAUL", "HAUT", "HAVE", "HAWK", "HAWS", "HAYS", "HAZE", "HAZY", "HEAD",
        "HEAL", "HEAP", "HEAR", "HEAT", "HEBE", "HECK", "HEED", "HEEL", "HEFT", "HEHS", "HEIL", "HEIR", "HELD", "HELM", "HELO", "HELP", "HEME", "HEMP", "HEMS",
        "HENS", "HENT", "HERB", "HERD", "HERE", "HERL", "HERM", "HERN", "HERO", "HERS", "HEST", "HETH", "HETS", "HEWN", "HEWS", "HICK", "HIDE", "HIED", "HIES",
        "HIGH", "HIKE", "HILA", "HILI", "HILL", "HILT", "HIMS", "HIND", "HINS", "HINT", "HIPS", "HIRE", "HISN", "HISS", "HIST", "HITS", "HIVE", "HOAR", "HOAX",
        "HOBO", "HOBS", "HOCK", "HODS", "HOED", "HOER", "HOES", "HOGG", "HOGS", "HOKE", "HOLD", "HOLK", "HOLM", "HOLP", "HOLS", "HOLT", "HOLY", "HOME", "HOMY",
        "HONE", "HONG", "HONS", "HOOD", "HOOF", "HOOK", "HOOP", "HOOT", "HOPE", "HOPS", "HORA", "HORN", "HOSE", "HOST", "HOTS", "HOUR", "HOVE", "HOWE", "HOWF",
        "HOWK", "HOWL", "HOWS", "HOYA", "HOYS", "HUBS", "HUCK", "HUED", "HUES", "HUFF", "HUGE", "HUGS", "HUIC", "HULA", "HULK", "HULL", "HUMP", "HUMS", "HUNG",
        "HUNH", "HUNK", "HUNS", "HUNT", "HURL", "HURT", "HUSH", "HUSK", "HUTS", "HWAN", "HYLA", "HYMN", "HYPE", "HYPO", "HYPS", "HYTE"
    };
    public static List<string> FourLetter_I = new List<string>()
    {
        "IAMB", "IBEX", "IBIS", "ICED", "ICES", "ICHS", "ICKY", "ICON", "IDEA", "IDEM", "IDES", "IDLE", "IDLY", "IDOL", "IDYL", "IFFY", "IGGS", "IGLU", "IKAT",
        "IKON", "ILEA", "ILEX", "ILIA", "ILKA", "ILKS", "ILLS", "ILLY", "IMAM", "IMID", "IMMY", "IMPI", "IMPS", "INBY", "INCH", "INFO", "INIA", "INKS", "INKY",
        "INLY", "INNS", "INRO", "INTI", "INTO", "IONS", "IOTA", "IRED", "IRES", "IRID", "IRIS", "IRKS", "IRON", "ISBA", "ISLE", "ISMS", "ITCH", "ITEM", "IWIS",
        "IXIA", "IZAR"
    };
    public static List<string> FourLetter_J = new List<string>()
    {
        "JABS", "JACK", "JADE", "JAGG", "JAGS", "JAIL", "JAKE", "JAMB", "JAMS", "JANE", "JAPE", "JARL", "JARS", "JATO", "JAUK", "JAUP", "JAVA", "JAWS", "JAYS",
        "JAZZ", "JEAN", "JEED", "JEEP", "JEER", "JEES", "JEEZ", "JEFE", "JEHU", "JELL", "JEON", "JERK", "JESS", "JEST", "JETE", "JETS", "JEUX", "JEWS", "JIAO",
        "JIBB", "JIBE", "JIBS", "JIFF", "JIGS", "JILL", "JILT", "JIMP", "JINK", "JINN", "JINS", "JINX", "JISM", "JIVE", "JIVY", "JOBS", "JOCK", "JOES", "JOEY",
        "JOGS", "JOHN", "JOIN", "JOKE", "JOKY", "JOLE", "JOLT", "JOSH", "JOSS", "JOTA", "JOTS", "JOUK", "JOWL", "JOWS", "JOYS", "JUBA", "JUBE", "JUCO", "JUDO",
        "JUGA", "JUGS", "JUJU", "JUKE", "JUKU", "JUMP", "JUNK", "JUPE", "JURA", "JURY", "JUST", "JUTE", "JUTS"
    };
    public static List<string> FourLetter_K = new List<string>()
    {
        "KAAS", "KABS", "KADI", "KAES", "KAFS", "KAGU", "KAIF", "KAIL", "KAIN", "KAKA", "KAKI", "KALE", "KAME", "KAMI", "KANA", "KANE", "KAON", "KAPA", "KAPH",
        "KARN", "KART", "KATA", "KATS", "KAVA", "KAYO", "KAYS", "KBAR", "KEAS", "KECK", "KEEF", "KEEK", "KEEL", "KEEN", "KEEP", "KEET", "KEFS", "KEGS", "KEIR",
        "KELP", "KELT", "KEMP", "KENO", "KENS", "KENT", "KEPI", "KEPS", "KEPT", "KERB", "KERF", "KERN", "KETO", "KEYS", "KHAF", "KHAN", "KHAT", "KHET", "KHIS",
        "KIBE", "KICK", "KIDS", "KIEF", "KIER", "KIFS", "KILL", "KILN", "KILO", "KILT", "KINA", "KIND", "KINE", "KING", "KINK", "KINO", "KINS", "KIPS", "KIRK",
        "KIRN", "KIRS", "KISS", "KIST", "KITE", "KITH", "KITS", "KIVA", "KIWI", "KLIK", "KNAP", "KNAR", "KNEE", "KNEW", "KNIT", "KNOB", "KNOP", "KNOT", "KNOW",
        "KNUR", "KOAN", "KOAS", "KOBO", "KOBS", "KOEL", "KOHL", "KOIS", "KOJI", "KOLA", "KOLO", "KONK", "KOOK", "KOPH", "KOPS", "KORA", "KORE", "KORS", "KOSS",
        "KOTO", "KRIS", "KUDO", "KUDU", "KUES", "KUFI", "KUNA", "KUNE", "KURU", "KVAS", "KYAK", "KYAR", "KYAT", "KYES", "KYTE"
    };
    public static List<string> FourLetter_L = new List<string>()
    {
        "LABS", "LACE", "LACK", "LACS", "LACY", "LADE", "LADS", "LADY", "LAGS", "LAIC", "LAID", "LAIN", "LAIR", "LAKE", "LAKH", "LAKY", "LALL", "LAMA", "LAMB",
        "LAME", "LAMP", "LAMS", "LAND", "LANE", "LANG", "LANK", "LAPS", "LARD", "LARI", "LARK", "LARS", "LASE", "LASH", "LASS", "LAST", "LATE", "LATH", "LATI",
        "LATS", "LATU", "LAUD", "LAVA", "LAVE", "LAVS", "LAWN", "LAWS", "LAYS", "LAZE", "LAZY", "LEAD", "LEAF", "LEAK", "LEAL", "LEAN", "LEAP", "LEAR", "LEAS",
        "LECH", "LEEK", "LEER", "LEES", "LEET", "LEFT", "LEGS", "LEHR", "LEIS", "LEKE", "LEKS", "LEKU", "LEND", "LENO", "LENS", "LENT", "LEPT", "LESS", "LEST",
        "LETS", "LEUD", "LEVA", "LEVO", "LEVY", "LEWD", "LEYS", "LIAR", "LIBS", "LICE", "LICH", "LICK", "LIDO", "LIDS", "LIED", "LIEF", "LIEN", "LIER", "LIES",
        "LIEU", "LIFE", "LIFT", "LIKE", "LILO", "LILT", "LILY", "LIMA", "LIMB", "LIME", "LIMN", "LIMO", "LIMP", "LIMY", "LINE", "LING", "LINK", "LINN", "LINO",
        "LINS", "LINT", "LINY", "LION", "LIPA", "LIPE", "LIPS", "LIRA", "LIRE", "LIRI", "LISP", "LIST", "LITE", "LITS", "LITU", "LIVE", "LOAD", "LOAF", "LOAM",
        "LOAN", "LOBE", "LOBO", "LOBS", "LOCA", "LOCH", "LOCI", "LOCK", "LOCO", "LODE", "LOFT", "LOGE", "LOGO", "LOGS", "LOGY", "LOID", "LOIN", "LOLL", "LONE",
        "LONG", "LOOF", "LOOK", "LOOM", "LOON", "LOOP", "LOOS", "LOOT", "LOPE", "LOPS", "LORD", "LORE", "LORN", "LORY", "LOSE", "LOSS", "LOST", "LOTA", "LOTH",
        "LOTI", "LOTS", "LOUD", "LOUP", "LOUR", "LOUT", "LOVE", "LOWE", "LOWN", "LOWS", "LUAU", "LUBE", "LUCE", "LUCK", "LUDE", "LUES", "LUFF", "LUGE", "LUGS",
        "LULL", "LULU", "LUMA", "LUMP", "LUMS", "LUNA", "LUNE", "LUNG", "LUNK", "LUNT", "LUNY", "LURE", "LURK", "LUSH", "LUST", "LUTE", "LUTZ", "LUVS", "LUXE",
        "LWEI", "LYCH", "LYES", "LYNX", "LYRE", "LYSE"
    };
    public static List<string> FourLetter_M = new List<string>()
    {
        "MAAR", "MABE", "MACE", "MACH", "MACK", "MACS", "MADE", "MADS", "MAES", "MAGE", "MAGI", "MAGS", "MAID", "MAIL", "MAIM", "MAIN", "MAIR", "MAKE", "MAKO",
        "MALE", "MALL", "MALM", "MALT", "MAMA", "MANA", "MANE", "MANO", "MANS", "MANY", "MAPS", "MARA", "MARC", "MARE", "MARK", "MARL", "MARS", "MART", "MASA",
        "MASH", "MASK", "MASS", "MAST", "MATE", "MATH", "MATS", "MATT", "MAUD", "MAUL", "MAUN", "MAUT", "MAWN", "MAWS", "MAXI", "MAYA", "MAYO", "MAYS", "MAZE",
        "MAZY", "MEAD", "MEAL", "MEAN", "MEAT", "MEDS", "MEED", "MEEK", "MEET", "MEGA", "MEGS", "MELD", "MELL", "MELS", "MELT", "MEME", "MEMO", "MEMS", "MEND",
        "MENO", "MENU", "MEOU", "MEOW", "MERC", "MERE", "MERK", "MERL", "MESA", "MESH", "MESS", "META", "METE", "METH", "MEWL", "MEWS", "MEZE", "MHOS", "MIBS",
        "MICA", "MICE", "MICS", "MIDI", "MIDS", "MIEN", "MIFF", "MIGG", "MIGS", "MIKE", "MILD", "MILE", "MILK", "MILL", "MILO", "MILS", "MILT", "MIME", "MINA",
        "MIND", "MINE", "MINI", "MINK", "MINT", "MINX", "MIPS", "MIRE", "MIRI", "MIRK", "MIRS", "MIRY", "MISE", "MISO", "MISS", "MIST", "MITE", "MITT", "MITY",
        "MIXT", "MOAN", "MOAS", "MOAT", "MOBS", "MOCK", "MOCS", "MODE", "MODI", "MODS", "MOGS", "MOIL", "MOJO", "MOKE", "MOLA", "MOLD", "MOLE", "MOLL", "MOLS",
        "MOLT", "MOLY", "MOME", "MOMI", "MOMS", "MONK", "MONO", "MONS", "MONY", "MOOD", "MOOL", "MOON", "MOOR", "MOOS", "MOOT", "MOPE", "MOPS", "MOPY", "MORA",
        "MORE", "MORN", "MORS", "MORT", "MOSH", "MOSK", "MOSS", "MOST", "MOTE", "MOTH", "MOTS", "MOTT", "MOUE", "MOVE", "MOWN", "MOWS", "MOXA", "MOZO", "MUCH",
        "MUCK", "MUDS", "MUFF", "MUGG", "MUGS", "MULE", "MULL", "MUMM", "MUMP", "MUMS", "MUMU", "MUNI", "MUNS", "MUON", "MURA", "MURE", "MURK", "MURR", "MUSE",
        "MUSH", "MUSK", "MUSS", "MUST", "MUTE", "MUTS", "MUTT", "MYCS", "MYNA", "MYTH"
    };
    public static List<string> FourLetter_N = new List<string>()
    {
        "NAAN", "NABE", "NABS", "NADA", "NAFF", "NAGS", "NAIF", "NAIL", "NALA", "NAME", "NANA", "NANS", "NAOI", "NAOS", "NAPA", "NAPE", "NAPS", "NARC", "NARD",
        "NARK", "NARY", "NAVE", "NAVY", "NAYS", "NAZI", "NEAP", "NEAR", "NEAT", "NEBS", "NECK", "NEED", "NEEM", "NEEP", "NEGS", "NEIF", "NEMA", "NENE", "NEON",
        "NERD", "NESS", "NEST", "NETS", "NETT", "NEUK", "NEUM", "NEVE", "NEVI", "NEWS", "NEWT", "NEXT", "NIBS", "NICE", "NICK", "NIDE", "NIDI", "NIGH", "NILL",
        "NILS", "NIMS", "NINE", "NIPA", "NIPS", "NISI", "NITE", "NITS", "NIXE", "NIXY", "NOBS", "NOCK", "NODE", "NODI", "NODS", "NOEL", "NOES", "NOGG", "NOGS",
        "NOIL", "NOIR", "NOLO", "NOMA", "NOME", "NOMS", "NONA", "NONE", "NOOK", "NOON", "NOPE", "NORI", "NORM", "NOSE", "NOSH", "NOSY", "NOTA", "NOTE", "NOUN",
        "NOUS", "NOVA", "NOWS", "NOWT", "NUBS", "NUDE", "NUKE", "NULL", "NUMB", "NUNS", "NURD", "NURL", "NUTS"
    };
    public static List<string> FourLetter_O = new List<string>()
    {
        "OAFS", "OAKS", "OAKY", "OARS", "OAST", "OATH", "OATS", "OBAS", "OBES", "OBEY", "OBIA", "OBIS", "OBIT", "OBOE", "OBOL", "OCAS", "ODAH", "ODAS", "ODDS",
        "ODEA", "ODES", "ODIC", "ODOR", "ODYL", "OFAY", "OFFS", "OGAM", "OGEE", "OGLE", "OGRE", "OHED", "OHIA", "OHMS", "OILS", "OILY", "OINK", "OKAS", "OKAY",
        "OKEH", "OKES", "OKRA", "OLDS", "OLDY", "OLEA", "OLEO", "OLES", "OLIO", "OLLA", "OMEN", "OMER", "OMIT", "ONCE", "ONES", "ONLY", "ONOS", "ONTO", "ONUS",
        "ONYX", "OOHS", "OOPS", "OOTS", "OOZE", "OOZY", "OPAH", "OPAL", "OPED", "OPEN", "OPES", "OPTS", "OPUS", "ORAD", "ORAL", "ORBS", "ORBY", "ORCA", "ORCS",
        "ORDO", "ORES", "ORGY", "ORLE", "ORRA", "ORTS", "ORYX", "ORZO", "OSAR", "OSES", "OSSA", "OTIC", "OTTO", "OUCH", "OUDS", "OUPH", "OURS", "OUST", "OUTS",
        "OUZO", "OVAL", "OVEN", "OVER", "OVUM", "OWED", "OWES", "OWLS", "OWNS", "OWSE", "OXEN", "OXES", "OXID", "OXIM", "OYER", "OYES", "OYEZ"
    };
    public static List<string> FourLetter_P = new List<string>()
    {
        "PACA", "PACE", "PACK", "PACS", "PACT", "PACY", "PADI", "PADS", "PAGE", "PAID", "PAIK", "PAIL", "PAIN", "PAIR", "PALE", "PALL", "PALM", "PALP", "PALS",
        "PALY", "PAMS", "PANE", "PANG", "PANS", "PANT", "PAPA", "PAPS", "PARA", "PARD", "PARE", "PARK", "PARR", "PARS", "PART", "PASE", "PASH", "PASS", "PAST",
        "PATE", "PATH", "PATS", "PATY", "PAVE", "PAWL", "PAWN", "PAWS", "PAYS", "PEAG", "PEAK", "PEAL", "PEAN", "PEAR", "PEAS", "PEAT", "PECH", "PECK", "PECS",
        "PEDS", "PEED", "PEEK", "PEEL", "PEEN", "PEEP", "PEER", "PEES", "PEGS", "PEHS", "PEIN", "PEKE", "PELE", "PELF", "PELT", "PEND", "PENS", "PENT", "PEON",
        "PEPO", "PEPS", "PERE", "PERI", "PERK", "PERM", "PERP", "PERT", "PERV", "PESO", "PEST", "PETS", "PEWS", "PFFT", "PFUI", "PHAT", "PHEW", "PHIS", "PHIZ",
        "PHON", "PHOT", "PHUT", "PIAL", "PIAN", "PIAS", "PICA", "PICE", "PICK", "PICS", "PIED", "PIER", "PIES", "PIGS", "PIKA", "PIKE", "PIKI", "PILE", "PILI",
        "PILL", "PILY", "PIMA", "PIMP", "PINA", "PINE", "PING", "PINK", "PINS", "PINT", "PINY", "PION", "PIPE", "PIPS", "PIPY", "PIRN", "PISH", "PISO", "PITA",
        "PITH", "PITS", "PITY", "PIXY", "PLAN", "PLAT", "PLAY", "PLEA", "PLEB", "PLED", "PLEW", "PLEX", "PLIE", "PLOD", "PLOP", "PLOT", "PLOW", "PLOY", "PLUG",
        "PLUM", "PLUS", "POCK", "POCO", "PODS", "POEM", "POET", "POGY", "POIS", "POKE", "POKY", "POLE", "POLL", "POLO", "POLS", "POLY", "POME", "POMO", "POMP",
        "POMS", "POND", "PONE", "PONG", "PONS", "PONY", "POOD", "POOF", "POOH", "POOL", "POON", "POOP", "POOR", "POOS", "POPE", "POPS", "PORE", "PORK", "PORN",
        "PORT", "POSE", "POSH", "POST", "POSY", "POTS", "POUF", "POUR", "POUT", "POWS", "POXY", "PRAM", "PRAO", "PRAT", "PRAU", "PRAY", "PREE", "PREP", "PREX",
        "PREY", "PREZ", "PRIG", "PRIM", "PROA", "PROD", "PROF", "PROG", "PROM", "PROP", "PROS", "PROW", "PSIS", "PSST", "PTUI", "PUBS", "PUCE", "PUCK", "PUDS",
        "PUFF", "PUGH", "PUGS", "PUJA", "PUKE", "PULA", "PULE", "PULI", "PULL", "PULP", "PULS", "PUMA", "PUMP", "PUNA", "PUNG", "PUNK", "PUNS", "PUNT", "PUNY",
        "PUPA", "PUPS", "PUPU", "PURE", "PURI", "PURL", "PURR", "PURS", "PUSH", "PUSS", "PUTS", "PUTT", "PUTZ", "PYAS", "PYES", "PYIC", "PYIN", "PYRE", "PYRO"
    };
    public static List<string> FourLetter_Q = new List<string>()
    {
        "QADI", "QAID", "QATS", "QOPH", "QUAD", "QUAG", "QUAI", "QUAY", "QUEY", "QUID", "QUIN", "QUIP", "QUIT", "QUIZ", "QUOD"
    };
    public static List<string> FourLetter_R = new List<string>()
    {
        "RACE", "RACK", "RACY", "RADS", "RAFF", "RAFT", "RAGA", "RAGE", "RAGG", "RAGI", "RAGS", "RAIA", "RAID", "RAIL", "RAIN", "RAIS", "RAJA", "RAKE", "RAKI",
        "RAKU", "RALE", "RAMI", "RAMP", "RAMS", "RAND", "RANG", "RANI", "RANK", "RANT", "RAPE", "RAPS", "RAPT", "RARE", "RASE", "RASH", "RASP", "RATE", "RATH",
        "RATO", "RATS", "RAVE", "RAWS", "RAYA", "RAYS", "RAZE", "RAZZ", "READ", "REAL", "REAM", "REAP", "REAR", "REBS", "RECK", "RECS", "REDD", "REDE", "REDO",
        "REDS", "REED", "REEF", "REEK", "REEL", "REES", "REFS", "REFT", "REGS", "REIF", "REIN", "REIS", "RELY", "REMS", "REND", "RENT", "REPO", "REPP", "REPS",
        "RESH", "REST", "RETE", "RETS", "REVS", "RHEA", "RHOS", "RHUS", "RIAL", "RIAS", "RIBS", "RICE", "RICH", "RICK", "RIDE", "RIDS", "RIEL", "RIFE", "RIFF",
        "RIFS", "RIFT", "RIGS", "RILE", "RILL", "RIME", "RIMS", "RIMY", "RIND", "RING", "RINK", "RINS", "RIOT", "RIPE", "RIPS", "RISE", "RISK", "RITE", "RITZ",
        "RIVE", "ROAD", "ROAM", "ROAN", "ROAR", "ROBE", "ROBS", "ROCK", "ROCS", "RODE", "RODS", "ROES", "ROIL", "ROLE", "ROLF", "ROLL", "ROMP", "ROMS", "ROOD",
        "ROOF", "ROOK", "ROOM", "ROOT", "ROPE", "ROPY", "ROSE", "ROSY", "ROTA", "ROTE", "ROTI", "ROTL", "ROTO", "ROTS", "ROUE", "ROUP", "ROUT", "ROUX", "ROVE",
        "ROWS", "RUBE", "RUBS", "RUBY", "RUCK", "RUDD", "RUDE", "RUED", "RUER", "RUES", "RUFF", "RUGA", "RUGS", "RUIN", "RULE", "RULY", "RUMP", "RUMS", "RUNE",
        "RUNG", "RUNS", "RUNT", "RUSE", "RUSH", "RUSK", "RUST", "RUTH", "RUTS", "RYAS", "RYES", "RYKE", "RYND", "RYOT"
    };
    public static List<string> FourLetter_S = new List<string>()
    {
        "SABE", "SABS", "SACK", "SACS", "SADE", "SADI", "SAFE", "SAGA", "SAGE", "SAGO", "SAGS", "SAGY", "SAID", "SAIL", "SAIN", "SAKE", "SAKI", "SALE", "SALL",
        "SALP", "SALS", "SALT", "SAME", "SAMP", "SAND", "SANE", "SANG", "SANK", "SANS", "SAPS", "SARD", "SARI", "SARK", "SASH", "SASS", "SATE", "SATI", "SAUL",
        "SAVE", "SAWN", "SAWS", "SAYS", "SCAB", "SCAD", "SCAG", "SCAM", "SCAN", "SCAR", "SCAT", "SCOP", "SCOT", "SCOW", "SCRY", "SCUD", "SCUM", "SCUP", "SCUT",
        "SEAL", "SEAM", "SEAR", "SEAS", "SEAT", "SECS", "SECT", "SEED", "SEEK", "SEEL", "SEEM", "SEEN", "SEEP", "SEER", "SEES", "SEGO", "SEGS", "SEIF", "SEIS",
        "SELF", "SELL", "SELS", "SEME", "SEMI", "SEND", "SENE", "SENT", "SEPT", "SERA", "SERE", "SERF", "SERS", "SETA", "SETS", "SETT", "SEWN", "SEWS", "SEXT",
        "SHAD", "SHAG", "SHAH", "SHAM", "SHAT", "SHAW", "SHAY", "SHEA", "SHED", "SHES", "SHEW", "SHIM", "SHIN", "SHIP", "SHIV", "SHMO", "SHOD", "SHOE", "SHOG",
        "SHOO", "SHOP", "SHOT", "SHOW", "SHRI", "SHUL", "SHUN", "SHUT", "SHWA", "SIAL", "SIBB", "SIBS", "SICE", "SICK", "SICS", "SIDE", "SIDH", "SIFT", "SIGH",
        "SIGN", "SIKA", "SIKE", "SILD", "SILK", "SILL", "SILO", "SILT", "SIMA", "SIMP", "SIMS", "SINE", "SING", "SINH", "SINK", "SINS", "SIPE", "SIPS", "SIRE",
        "SIRS", "SITE", "SITH", "SITS", "SIZE", "SIZY", "SKAG", "SKAS", "SKAT", "SKEE", "SKEG", "SKEP", "SKEW", "SKID", "SKIM", "SKIN", "SKIP", "SKIS", "SKIT",
        "SKUA", "SLAB", "SLAG", "SLAM", "SLAP", "SLAT", "SLAW", "SLAY", "SLED", "SLEW", "SLID", "SLIM", "SLIP", "SLIT", "SLOB", "SLOE", "SLOG", "SLOP", "SLOT",
        "SLOW", "SLUB", "SLUE", "SLUG", "SLUM", "SLUR", "SMEW", "SMIT", "SMOG", "SMUG", "SMUT", "SNAG", "SNAP", "SNAW", "SNED", "SNIB", "SNIP", "SNIT", "SNOB",
        "SNOG", "SNOT", "SNOW", "SNUB", "SNUG", "SNYE", "SOAK", "SOAP", "SOAR", "SOBA", "SOBS", "SOCA", "SOCK", "SODA", "SODS", "SOFA", "SOFT", "SOIL", "SOJA",
        "SOKE", "SOLA", "SOLD", "SOLE", "SOLI", "SOLO", "SOLS", "SOMA", "SOME", "SOMS", "SONE", "SONG", "SONS", "SOOK", "SOON", "SOOT", "SOPH", "SOPS", "SORA",
        "SORB", "SORD", "SORE", "SORI", "SORN", "SORT", "SOTH", "SOTS", "SOUK", "SOUL", "SOUP", "SOUR", "SOUS", "SOWN", "SOWS", "SOYA", "SOYS", "SPAE", "SPAM",
        "SPAN", "SPAR", "SPAS", "SPAT", "SPAY", "SPAZ", "SPEC", "SPED", "SPEW", "SPIK", "SPIN", "SPIT", "SPIV", "SPOT", "SPRY", "SPUD", "SPUE", "SPUN", "SPUR",
        "SRIS", "STAB", "STAG", "STAR", "STAT", "STAW", "STAY", "STEM", "STEP", "STET", "STEW", "STEY", "STIR", "STOA", "STOB", "STOP", "STOT", "STOW", "STUB",
        "STUD", "STUM", "STUN", "STYE", "SUBA", "SUBS", "SUCH", "SUDD", "SUDS", "SUED", "SUER", "SUES", "SUET", "SUGH", "SUIT", "SUKS", "SULK", "SULU", "SUMO",
        "SUMP", "SUMS", "SUNG", "SUNK", "SUNN", "SUNS", "SUPE", "SUPS", "SUQS", "SURA", "SURD", "SURE", "SURF", "SUSS", "SWAB", "SWAG", "SWAM", "SWAN", "SWAP",
        "SWAT", "SWAY", "SWIG", "SWIM", "SWOB", "SWOP", "SWOT", "SWUM", "SYBO", "SYCE", "SYKE", "SYLI", "SYNC", "SYNE", "SYPH"
    };
    public static List<string> FourLetter_T = new List<string>()
    {
        "TABS", "TABU", "TACE", "TACH", "TACK", "TACO", "TACT", "TADS", "TAEL", "TAGS", "TAHR", "TAIL", "TAIN", "TAKA", "TAKE", "TALA", "TALC", "TALE", "TALI",
        "TALK", "TALL", "TAME", "TAMP", "TAMS", "TANG", "TANK", "TANS", "TAOS", "TAPA", "TAPE", "TAPS", "TARE", "TARN", "TARO", "TARP", "TARS", "TART", "TASK",
        "TASS", "TATE", "TATS", "TAUS", "TAUT", "TAVS", "TAWS", "TAXA", "TAXI", "TEAK", "TEAL", "TEAM", "TEAR", "TEAS", "TEAT", "TECH", "TEDS", "TEED", "TEEL",
        "TEEM", "TEEN", "TEES", "TEFF", "TEGG", "TEGS", "TELA", "TELE", "TELL", "TELS", "TEMP", "TEND", "TENS", "TENT", "TEPA", "TERM", "TERN", "TEST", "TETH",
        "TETS", "TEWS", "TEXT", "THAE", "THAN", "THAT", "THAW", "THEE", "THEM", "THEN", "THEW", "THEY", "THIN", "THIO", "THIR", "THIS", "THOU", "THRO", "THRU",
        "THUD", "THUG", "THUS", "TICK", "TICS", "TIDE", "TIDY", "TIED", "TIER", "TIES", "TIFF", "TIKE", "TIKI", "TILE", "TILL", "TILS", "TILT", "TIME", "TINE",
        "TING", "TINS", "TINT", "TINY", "TIPI", "TIPS", "TIRE", "TIRL", "TIRO", "TITI", "TIVY", "TOAD", "TOBY", "TODS", "TODY", "TOEA", "TOED", "TOES", "TOFF",
        "TOFT", "TOFU", "TOGA", "TOGS", "TOIL", "TOIT", "TOKE", "TOLA", "TOLD", "TOLE", "TOLL", "TOLU", "TOMB", "TOME", "TOMS", "TONE", "TONG", "TONS", "TONY",
        "TOOK", "TOOL", "TOOM", "TOON", "TOOT", "TOPE", "TOPH", "TOPI", "TOPO", "TOPS", "TORA", "TORC", "TORE", "TORI", "TORN", "TORO", "TORR", "TORS", "TORT",
        "TORY", "TOSH", "TOSS", "TOST", "TOTE", "TOTS", "TOUR", "TOUT", "TOWN", "TOWS", "TOWY", "TOYO", "TOYS", "TRAD", "TRAM", "TRAP", "TRAY", "TREE", "TREF",
        "TREK", "TRES", "TRET", "TREY", "TRIG", "TRIM", "TRIO", "TRIP", "TROD", "TROG", "TROP", "TROT", "TROW", "TROY", "TRUE", "TRUG", "TSAR", "TSKS", "TUBA",
        "TUBE", "TUBS", "TUCK", "TUFA", "TUFF", "TUFT", "TUGS", "TUIS", "TULE", "TUMP", "TUNA", "TUNE", "TUNG", "TUNS", "TUPS", "TURD", "TURF", "TURK", "TURN",
        "TUSH", "TUSK", "TUTS", "TUTU", "TWAE", "TWAS", "TWEE", "TWIG", "TWIN", "TWIT", "TWOS", "TYEE", "TYER", "TYES", "TYIN", "TYKE", "TYNE", "TYPE", "TYPO",
        "TYPP", "TYPY", "TYRE", "TYRO", "TZAR"
    };
    public static List<string> FourLetter_U = new List<string>()
    {
        "UDON", "UDOS", "UGHS", "UGLY", "UKES", "ULAN", "ULNA", "ULUS", "ULVA", "UMBO", "UMPS", "UNAI", "UNAU", "UNBE", "UNCI", "UNCO", "UNDE", "UNDO", "UNDY",
        "UNIT", "UNTO", "UPAS", "UPBY", "UPDO", "UPON", "URBS", "URDS", "UREA", "URGE", "URIC", "URNS", "URPS", "URSA", "URUS", "USED", "USER", "USES", "UTAS",
        "UTES", "UVEA"
    };
    public static List<string> FourLetter_V = new List<string>()
    {
        "VACS", "VAGI", "VAIL", "VAIN", "VAIR", "VALE", "VAMP", "VANE", "VANG", "VANS", "VARA", "VARS", "VARY", "VASA", "VASE", "VAST", "VATS", "VATU", "VAUS",
        "VAVS", "VAWS", "VEAL", "VEEP", "VEER", "VEES", "VEIL", "VEIN", "VELA", "VELD", "VENA", "VEND", "VENT", "VERA", "VERB", "VERT", "VERY", "VEST", "VETO",
        "VETS", "VEXT", "VIAL", "VIBE", "VICE", "VIDE", "VIDS", "VIED", "VIER", "VIES", "VIEW", "VIGA", "VIGS", "VILE", "VILL", "VIMS", "VINA", "VINE", "VINO",
        "VINY", "VIOL", "VIRL", "VISA", "VISE", "VITA", "VIVA", "VIVE", "VOES", "VOID", "VOLE", "VOLT", "VOTE", "VOWS", "VROW", "VUGG", "VUGH", "VUGS"
    };
    public static List<string> FourLetter_W = new List<string>()
    {
        "WABS", "WACK", "WADE", "WADI", "WADS", "WADY", "WAES", "WAFF", "WAFT", "WAGE", "WAGS", "WAIF", "WAIL", "WAIN", "WAIR", "WAIT", "WAKE", "WALE", "WALK",
        "WALL", "WALY", "WAME", "WAND", "WANE", "WANS", "WANT", "WANY", "WAPS", "WARD", "WARE", "WARK", "WARM", "WARN", "WARP", "WARS", "WART", "WARY", "WASH",
        "WASP", "WAST", "WATS", "WATT", "WAUK", "WAUL", "WAUR", "WAVE", "WAVY", "WAWL", "WAWS", "WAXY", "WAYS", "WEAK", "WEAL", "WEAN", "WEAR", "WEBS", "WEDS",
        "WEED", "WEEK", "WEEL", "WEEN", "WEEP", "WEER", "WEES", "WEET", "WEFT", "WEIR", "WEKA", "WELD", "WELL", "WELT", "WEND", "WENS", "WENT", "WEPT", "WERE",
        "WERT", "WEST", "WETS", "WHAM", "WHAP", "WHAT", "WHEE", "WHEN", "WHET", "WHEW", "WHEY", "WHID", "WHIG", "WHIM", "WHIN", "WHIP", "WHIR", "WHIT", "WHIZ",
        "WHOA", "WHOM", "WHOP", "WHUP", "WHYS", "WICH", "WICK", "WIDE", "WIFE", "WIGS", "WILD", "WILE", "WILL", "WILT", "WILY", "WIMP", "WIND", "WINE", "WING",
        "WINK", "WINO", "WINS", "WINY", "WIPE", "WIRE", "WIRY", "WISE", "WISH", "WISP", "WISS", "WIST", "WITE", "WITH", "WITS", "WIVE", "WOAD", "WOES", "WOKE",
        "WOKS", "WOLD", "WOLF", "WOMB", "WONK", "WONS", "WONT", "WOOD", "WOOF", "WOOL", "WOOS", "WORD", "WORE", "WORK", "WORM", "WORN", "WORT", "WOST", "WOTS",
        "WOVE", "WOWS", "WRAP", "WREN", "WRIT", "WUSS", "WYCH", "WYES", "WYLE", "WYND", "WYNN", "WYNS", "WYTE"
    };
    public static List<string> FourLetter_X = new List<string>()
    {
        "XYST"
    };
    public static List<string> FourLetter_Y = new List<string>()
    {
        "YACK", "YAFF", "YAGI", "YAGS", "YAKS", "YALD", "YAMS", "YANG", "YANK", "YAPS", "YARD", "YARE", "YARN", "YAUD", "YAUP", "YAWL", "YAWN", "YAWP", "YAWS",
        "YAYS", "YEAH", "YEAN", "YEAR", "YEAS", "YECH", "YEGG", "YELD", "YELK", "YELL", "YELP", "YENS", "YEPS", "YERK", "YETI", "YETT", "YEUK", "YEWS", "YILL",
        "YINS", "YIPE", "YIPS", "YIRD", "YIRR", "YLEM", "YOBS", "YOCK", "YODH", "YODS", "YOGA", "YOGH", "YOGI", "YOKE", "YOKS", "YOLK", "YOND", "YONI", "YORE",
        "YOUR", "YOUS", "YOWE", "YOWL", "YOWS", "YUAN", "YUCA", "YUCH", "YUCK", "YUGA", "YUKS", "YULE", "YUPS", "YURT", "YUTZ", "YWIS"
    };
    public static List<string> FourLetter_Z = new List<string>()
    {
        "ZAGS", "ZANY", "ZAPS", "ZARF", "ZEAL", "ZEBU", "ZEDS", "ZEES", "ZEIN", "ZEKS", "ZEPS", "ZERK", "ZERO", "ZEST", "ZETA", "ZIGS", "ZILL", "ZINC", "ZINE",
        "ZING", "ZINS", "ZIPS", "ZITI", "ZITS", "ZOEA", "ZOIC", "ZONA", "ZONE", "ZONK", "ZOOM", "ZOON", "ZOOS", "ZORI", "ZOUK", "ZYME"
    };

    public static List<string> FiveLetter_A = new List<string>()
    {
        "AAHED", "AALII", "AARGH", "ABACA", "ABACI", "ABACK", "ABAFT", "ABAKA", "ABAMP", "ABASE", "ABASH", "ABATE", "ABAYA", "ABBAS", "ABBES", "ABBEY", "ABBOT",
        "ABEAM", "ABELE", "ABETS", "ABHOR", "ABIDE", "ABLED", "ABLER", "ABLES", "ABMHO", "ABODE", "ABOHM", "ABOIL", "ABOMA", "ABOON", "ABORT", "ABOUT", "ABOVE",
        "ABRIS", "ABUSE", "ABUTS", "ABUZZ", "ABYES", "ABYSM", "ABYSS", "ACARI", "ACERB", "ACETA", "ACHED", "ACHES", "ACHOO", "ACIDS", "ACIDY", "ACING", "ACINI",
        "ACKEE", "ACMES", "ACMIC", "ACNED", "ACNES", "ACOCK", "ACOLD", "ACORN", "ACRED", "ACRES", "ACRID", "ACTED", "ACTIN", "ACTOR", "ACUTE", "ACYLS", "ADAGE",
        "ADAPT", "ADDAX", "ADDED", "ADDER", "ADDLE", "ADEEM", "ADEPT", "ADIEU", "ADIOS", "ADITS", "ADMAN", "ADMEN", "ADMIT", "ADMIX", "ADOBE", "ADOBO", "ADOPT",
        "ADORE", "ADORN", "ADOWN", "ADOZE", "ADULT", "ADUNC", "ADUST", "ADYTA", "ADZED", "ADZES", "AECIA", "AEDES", "AEGIS", "AEONS", "AERIE", "AFARS", "AFFIX",
        "AFIRE", "AFOOT", "AFORE", "AFOUL", "AFRIT", "AFTER", "AGAIN", "AGAMA", "AGAPE", "AGARS", "AGATE", "AGAVE", "AGAZE", "AGENE", "AGENT", "AGERS", "AGGER",
        "AGGIE", "AGGRO", "AGHAS", "AGILE", "AGING", "AGIOS", "AGISM", "AGIST", "AGITA", "AGLEE", "AGLET", "AGLEY", "AGLOW", "AGMAS", "AGONE", "AGONS", "AGONY",
        "AGORA", "AGREE", "AGRIA", "AGUES", "AHEAD", "AHING", "AHOLD", "AHULL", "AIDED", "AIDER", "AIDES", "AILED", "AIMED", "AIMER", "AIOLI", "AIRED", "AIRER",
        "AIRNS", "AIRTH", "AIRTS", "AISLE", "AITCH", "AIVER", "AJIVA", "AJUGA", "AKEES", "AKELA", "AKENE", "ALACK", "ALAMO", "ALAND", "ALANE", "ALANG", "ALANS",
        "ALANT", "ALARM", "ALARY", "ALATE", "ALBAS", "ALBUM", "ALCID", "ALDER", "ALDOL", "ALECS", "ALEFS", "ALEPH", "ALERT", "ALFAS", "ALGAE", "ALGAL", "ALGAS",
        "ALGID", "ALGIN", "ALGOR", "ALGUM", "ALIAS", "ALIBI", "ALIEN", "ALIFS", "ALIGN", "ALIKE", "ALINE", "ALIST", "ALIVE", "ALIYA", "ALKIE", "ALKYD", "ALKYL",
        "ALLAY", "ALLEE", "ALLEY", "ALLOD", "ALLOT", "ALLOW", "ALLOY", "ALLYL", "ALMAH", "ALMAS", "ALMEH", "ALMES", "ALMUD", "ALMUG", "ALOES", "ALOFT", "ALOHA",
        "ALOIN", "ALONE", "ALONG", "ALOOF", "ALOUD", "ALPHA", "ALTAR", "ALTER", "ALTHO", "ALTOS", "ALULA", "ALUMS", "ALWAY", "AMAHS", "AMAIN", "AMASS", "AMAZE",
        "AMBER", "AMBIT", "AMBLE", "AMBOS", "AMBRY", "AMEBA", "AMEER", "AMEND", "AMENS", "AMENT", "AMIAS", "AMICE", "AMICI", "AMIDE", "AMIDO", "AMIDS", "AMIES",
        "AMIGA", "AMIGO", "AMINE", "AMINO", "AMINS", "AMIRS", "AMISS", "AMITY", "AMMOS", "AMNIA", "AMNIC", "AMNIO", "AMOKS", "AMOLE", "AMONG", "AMORT", "AMOUR",
        "AMPED", "AMPLE", "AMPLY", "AMPUL", "AMUCK", "AMUSE", "AMYLS", "ANCHO", "ANCON", "ANDRO", "ANEAR", "ANELE", "ANENT", "ANGAS", "ANGEL", "ANGER", "ANGLE",
        "ANGLO", "ANGRY", "ANGST", "ANILE", "ANILS", "ANIMA", "ANIME", "ANIMI", "ANION", "ANISE", "ANKHS", "ANKLE", "ANKUS", "ANLAS", "ANNAL", "ANNAS", "ANNEX",
        "ANNOY", "ANNUL", "ANOAS", "ANODE", "ANOLE", "ANOMY", "ANSAE", "ANTAE", "ANTAS", "ANTED", "ANTES", "ANTIC", "ANTIS", "ANTRA", "ANTRE", "ANTSY", "ANVIL",
        "ANYON", "AORTA", "APACE", "APART", "APEAK", "APEEK", "APERS", "APERY", "APHID", "APHIS", "APIAN", "APING", "APISH", "APNEA", "APODS", "APORT", "APPAL",
        "APPEL", "APPLE", "APPLY", "APRES", "APRON", "APSES", "APSIS", "APTER", "APTLY", "AQUAE", "AQUAS", "ARAKS", "ARAME", "ARBOR", "ARCED", "ARCUS", "ARDEB",
        "ARDOR", "AREAE", "AREAL", "AREAS", "ARECA", "AREIC", "ARENA", "ARENE", "AREPA", "ARETE", "ARGAL", "ARGIL", "ARGLE", "ARGOL", "ARGON", "ARGOT", "ARGUE",
        "ARGUS", "ARHAT", "ARIAS", "ARIEL", "ARILS", "ARISE", "ARLES", "ARMED", "ARMER", "ARMET", "ARMOR", "AROID", "AROMA", "AROSE", "ARPEN", "ARRAS", "ARRAY",
        "ARRIS", "ARROW", "ARSES", "ARSIS", "ARSON", "ARTAL", "ARTEL", "ARTSY", "ARUMS", "ARVAL", "ARVOS", "ARYLS", "ASANA", "ASCOT", "ASCUS", "ASDIC", "ASHED",
        "ASHEN", "ASHES", "ASIDE", "ASKED", "ASKER", "ASKEW", "ASKOI", "ASKOS", "ASPEN", "ASPER", "ASPIC", "ASPIS", "ASSAI", "ASSAY", "ASSES", "ASSET", "ASTER",
        "ASTIR", "ASYLA", "ATAPS", "ATAXY", "ATILT", "ATLAS", "ATMAN", "ATMAS", "ATOLL", "ATOMS", "ATOMY", "ATONE", "ATONY", "ATOPY", "ATRIA", "ATRIP", "ATTAR",
        "ATTIC", "AUDAD", "AUDIO", "AUDIT", "AUGER", "AUGHT", "AUGUR", "AULIC", "AUNTS", "AUNTY", "AURAE", "AURAL", "AURAR", "AURAS", "AUREI", "AURES", "AURIC",
        "AURIS", "AURUM", "AUTOS", "AUXIN", "AVAIL", "AVANT", "AVAST", "AVENS", "AVERS", "AVERT", "AVGAS", "AVIAN", "AVION", "AVISO", "AVOID", "AVOWS", "AWAIT",
        "AWAKE", "AWARD", "AWARE", "AWASH", "AWFUL", "AWING", "AWNED", "AWOKE", "AWOLS", "AXELS", "AXIAL", "AXILE", "AXILS", "AXING", "AXIOM", "AXION", "AXITE",
        "AXLED", "AXLES", "AXMAN", "AXMEN", "AXONE", "AXONS", "AYAHS", "AYINS", "AZANS", "AZIDE", "AZIDO", "AZINE", "AZLON", "AZOIC", "AZOLE", "AZONS", "AZOTE",
        "AZOTH", "AZUKI", "AZURE"
    };
    public static List<string> FiveLetter_B = new List<string>()
    {
        "BAAED", "BAALS", "BABAS", "BABEL", "BABES", "BABKA", "BABOO", "BABUL", "BABUS", "BACCA", "BACKS", "BACON", "BADDY", "BADGE", "BADLY", "BAFFS", "BAFFY",
        "BAGEL", "BAGGY", "BAHTS", "BAILS", "BAIRN", "BAITH", "BAITS", "BAIZA", "BAIZE", "BAKED", "BAKER", "BAKES", "BALAS", "BALDS", "BALDY", "BALED", "BALER",
        "BALES", "BALKS", "BALKY", "BALLS", "BALLY", "BALMS", "BALMY", "BALSA", "BANAL", "BANCO", "BANDA", "BANDS", "BANDY", "BANED", "BANES", "BANGS", "BANJO",
        "BANKS", "BANNS", "BANTY", "BARBE", "BARBS", "BARCA", "BARDE", "BARDS", "BARED", "BARER", "BARES", "BARFS", "BARGE", "BARIC", "BARKS", "BARKY", "BARMS",
        "BARMY", "BARNS", "BARNY", "BARON", "BARRE", "BARYE", "BASAL", "BASED", "BASER", "BASES", "BASIC", "BASIL", "BASIN", "BASIS", "BASKS", "BASSI", "BASSO",
        "BASSY", "BASTE", "BASTS", "BATCH", "BATED", "BATES", "BATHE", "BATHS", "BATIK", "BATON", "BATTS", "BATTU", "BATTY", "BAUDS", "BAULK", "BAWDS", "BAWDY",
        "BAWLS", "BAWTY", "BAYED", "BAYOU", "BAZAR", "BAZOO", "BEACH", "BEADS", "BEADY", "BEAKS", "BEAKY", "BEAMS", "BEAMY", "BEANO", "BEANS", "BEARD", "BEARS",
        "BEAST", "BEATS", "BEAUS", "BEAUT", "BEAUX", "BEBOP", "BECAP", "BECKS", "BEDEL", "BEDEW", "BEDIM", "BEECH", "BEEDI", "BEEFS", "BEEFY", "BEEPS", "BEERS",
        "BEERY", "BEETS", "BEFIT", "BEFOG", "BEGAN", "BEGAT", "BEGET", "BEGIN", "BEGOT", "BEGUM", "BEGUN", "BEIGE", "BEIGY", "BEING", "BELAY", "BELCH", "BELGA",
        "BELIE", "BELLE", "BELLS", "BELLY", "BELON", "BELOW", "BELTS", "BEMAS", "BEMIX", "BENCH", "BENDS", "BENDY", "BENES", "BENNE", "BENNI", "BENNY", "BENTO",
        "BENTS", "BERET", "BERGS", "BERKS", "BERME", "BERMS", "BERRY", "BERTH", "BERYL", "BESES", "BESET", "BESOM", "BESOT", "BESTS", "BETAS", "BETEL", "BETHS",
        "BETON", "BETTA", "BEVEL", "BEVOR", "BEWIG", "BEZEL", "BEZIL", "BHANG", "BHOOT", "BHUTS", "BIALI", "BIALY", "BIBBS", "BIBLE", "BICEP", "BICES", "BIDDY",
        "BIDED", "BIDER", "BIDES", "BIDET", "BIDIS", "BIELD", "BIERS", "BIFFS", "BIFFY", "BIFID", "BIGGY", "BIGHT", "BIGLY", "BIGOS", "BIGOT", "BIJOU", "BIKED",
        "BIKER", "BIKES", "BIKIE", "BILBO", "BILBY", "BILES", "BILGE", "BILGY", "BILKS", "BILLS", "BILLY", "BIMAH", "BIMAS", "BINAL", "BINDI", "BINDS", "BINER",
        "BINES", "BINGE", "BINGO", "BINIT", "BINTS", "BIOGS", "BIOME", "BIONT", "BIOTA", "BIPED", "BIPOD", "BIRCH", "BIRDS", "BIRKS", "BIRLE", "BIRLS", "BIROS",
        "BIRRS", "BIRSE", "BIRTH", "BISES", "BISKS", "BISON", "BITER", "BITES", "BITSY", "BITTS", "BITTY", "BIZES", "BLABS", "BLADE", "BLAFF", "BLAHS", "BLAIN",
        "BLAME", "BLAMS", "BLAND", "BLANK", "BLARE", "BLASE", "BLAST", "BLATE", "BLATS", "BLAWN", "BLAWS", "BLAZE", "BLEAK", "BLEAR", "BLEAT", "BLEBS", "BLEED",
        "BLEEP", "BLEND", "BLENT", "BLESS", "BLEST", "BLETS", "BLIMP", "BLIMY", "BLIND", "BLINI", "BLINK", "BLIPS", "BLISS", "BLITE", "BLITZ", "BLOAT", "BLOBS",
        "BLOCK", "BLOCS", "BLOGS", "BLOKE", "BLOND", "BLOOD", "BLOOM", "BLOOP", "BLOTS", "BLOWN", "BLOWS", "BLOWY", "BLUBS", "BLUED", "BLUER", "BLUES", "BLUET",
        "BLUEY", "BLUFF", "BLUME", "BLUNT", "BLURB", "BLURS", "BLURT", "BLUSH", "BLYPE", "BOARD", "BOARS", "BOART", "BOAST", "BOATS", "BOBBY", "BOCCE", "BOCCI",
        "BOCHE", "BOCKS", "BODED", "BODES", "BOFFO", "BOFFS", "BOGAN", "BOGEY", "BOGGY", "BOGIE", "BOGLE", "BOGUS", "BOHEA", "BOHOS", "BOILS", "BOING", "BOINK",
        "BOITE", "BOLAR", "BOLAS", "BOLDS", "BOLES", "BOLLS", "BOLOS", "BOLTS", "BOLUS", "BOMBE", "BOMBS", "BONDS", "BONED", "BONES", "BONEY", "BONGO", "BONGS",
        "BONKS", "BONNE", "BONNY", "BONUS", "BONZE", "BOOBS", "BOOBY", "BOODY", "BOOED", "BOOGY", "BOOKS", "BOOMS", "BOOMY", "BOONS", "BOORS", "BOOST", "BOOTH",
        "BOOTS", "BOOTY", "BOOZE", "BOOZY", "BORAL", "BORAS", "BORAX", "BORED", "BORER", "BORES", "BORIC", "BORKS", "BORNE", "BORON", "BORTS", "BORTY", "BORTZ",
        "BOSKS", "BOSKY", "BOSOM", "BOSON", "BOSSY", "BOSUN", "BOTAS", "BOTCH", "BOTEL", "BOTHY", "BOTTS", "BOUGH", "BOULE", "BOUND", "BOURG", "BOURN", "BOUSE",
        "BOUSY", "BOUTS", "BOVID", "BOWED", "BOWEL", "BOWER", "BOWLS", "BOWSE", "BOXED", "BOXER", "BOXES", "BOYAR", "BOYLA", "BOYOS", "BOZOS", "BRACE", "BRACH",
        "BRACT", "BRADS", "BRAES", "BRAGS", "BRAID", "BRAIL", "BRAIN", "BRAKE", "BRAKY", "BRAND", "BRANK", "BRANS", "BRANT", "BRASH", "BRASS", "BRATS", "BRAVA",
        "BRAVE", "BRAVI", "BRAVO", "BRAWL", "BRAWN", "BRAWS", "BRAXY", "BRAYS", "BRAZA", "BRAZE", "BREAD", "BREAK", "BREAM", "BREDE", "BREED", "BREES", "BRENS",
        "BRENT", "BREVE", "BREWS", "BRIAR", "BRIBE", "BRICK", "BRIDE", "BRIEF", "BRIER", "BRIES", "BRIGS", "BRILL", "BRIMS", "BRINE", "BRING", "BRINK", "BRINS",
        "BRINY", "BRIOS", "BRISK", "BRISS", "BRITH", "BRITS", "BRITT", "BROAD", "BROCK", "BROIL", "BROKE", "BROME", "BROMO", "BRONC", "BROOD", "BROOK", "BROOM",
        "BROOS", "BROSE", "BROSY", "BROTH", "BROWN", "BROWS", "BRUGH", "BRUIN", "BRUIT", "BRUME", "BRUNG", "BRUNT", "BRUSH", "BRUSK", "BRUTE", "BRUTS", "BUBAL",
        "BUBBA", "BUBBY", "BUBUS", "BUCKO", "BUCKS", "BUDDY", "BUDGE", "BUFFI", "BUFFO", "BUFFS", "BUFFY", "BUGGY", "BUGLE", "BUHLS", "BUHRS", "BUILD", "BUILT",
        "BULBS", "BULGE", "BULGY", "BULKS", "BULKY", "BULLA", "BULLS", "BULLY", "BUMFS", "BUMPH", "BUMPS", "BUMPY", "BUNAS", "BUNCH", "BUNCO", "BUNDS", "BUNDT",
        "BUNGS", "BUNKO", "BUNKS", "BUNNS", "BUNNY", "BUNTS", "BUNYA", "BUOYS", "BUPPY", "BURAN", "BURAS", "BURBS", "BURDS", "BURET", "BURGH", "BURGS", "BURIN",
        "BURKA", "BURKE", "BURLS", "BURLY", "BURNS", "BURNT", "BURPS", "BURQA", "BURRO", "BURRS", "BURRY", "BURSA", "BURSE", "BURST", "BUSBY", "BUSED", "BUSES",
        "BUSHY", "BUSKS", "BUSTS", "BUSTY", "BUTCH", "BUTEO", "BUTES", "BUTLE", "BUTTE", "BUTTS", "BUTTY", "BUTUT", "BUTYL", "BUXOM", "BUYER", "BWANA", "BYLAW",
        "BYRES", "BYRLS", "BYSSI", "BYTES", "BYWAY"
    };
    public static List<string> FiveLetter_C = new List<string>()
    {
        "CABAL", "CABBY", "CABER", "CABIN", "CABLE", "CABOB", "CACAO", "CACAS", "CACHE", "CACTI", "CADDY", "CADES", "CADET", "CADGE", "CADGY", "CADIS", "CADRE",
        "CAECA", "CAFES", "CAFFS", "CAGED", "CAGER", "CAGES", "CAGEY", "CAHOW", "CAIDS", "CAINS", "CAIRD", "CAIRN", "CAJON", "CAKED", "CAKES", "CAKEY", "CALFS",
        "CALIF", "CALIX", "CALKS", "CALLA", "CALLS", "CALMS", "CALOS", "CALVE", "CALYX", "CAMAS", "CAMEL", "CAMEO", "CAMES", "CAMOS", "CAMPI", "CAMPO", "CAMPS",
        "CAMPY", "CANAL", "CANDY", "CANED", "CANER", "CANES", "CANID", "CANNA", "CANNY", "CANOE", "CANON", "CANSO", "CANST", "CANTO", "CANTS", "CANTY", "CAPED",
        "CAPER", "CAPES", "CAPHS", "CAPIZ", "CAPON", "CAPOS", "CAPUT", "CARAT", "CARBO", "CARBS", "CARDS", "CARED", "CARER", "CARES", "CARET", "CAREX", "CARGO",
        "CARKS", "CARLE", "CARLS", "CARNS", "CARNY", "CAROB", "CAROL", "CAROM", "CARPI", "CARPS", "CARRS", "CARRY", "CARSE", "CARTE", "CARTS", "CARVE", "CASAS",
        "CASED", "CASES", "CASKS", "CASKY", "CASTE", "CASTS", "CASUS", "CATCH", "CATER", "CATES", "CATTY", "CAULD", "CAULK", "CAULS", "CAUSE", "CAVED", "CAVER",
        "CAVES", "CAVIE", "CAVIL", "CAWED", "CEASE", "CEBID", "CECAL", "CECUM", "CEDAR", "CEDED", "CEDER", "CEDES", "CEDIS", "CEIBA", "CEILI", "CEILS", "CELEB",
        "CELLA", "CELLI", "CELLO", "CELLS", "CELOM", "CELTS", "CENSE", "CENTO", "CENTS", "CENTU", "CEORL", "CEPES", "CERCI", "CERED", "CERES", "CERIA", "CERIC",
        "CEROS", "CESTA", "CESTI", "CETES", "CHADS", "CHAFE", "CHAFF", "CHAIN", "CHAIR", "CHAIS", "CHALK", "CHAMP", "CHAMS", "CHANG", "CHANT", "CHAOS", "CHAPE",
        "CHAPS", "CHAPT", "CHARD", "CHARE", "CHARK", "CHARM", "CHARR", "CHARS", "CHART", "CHARY", "CHASE", "CHASM", "CHATS", "CHAWS", "CHAYS", "CHEAP", "CHEAT",
        "CHECK", "CHEEK", "CHEEP", "CHEER", "CHEFS", "CHELA", "CHEMO", "CHERT", "CHESS", "CHEST", "CHETH", "CHEVY", "CHEWS", "CHEWY", "CHIAO", "CHIAS", "CHICA",
        "CHICK", "CHICO", "CHICS", "CHIDE", "CHIEF", "CHIEL", "CHILD", "CHILE", "CHILI", "CHILL", "CHIMB", "CHIME", "CHIMP", "CHINA", "CHINE", "CHINO", "CHINS",
        "CHIPS", "CHIRK", "CHIRM", "CHIRO", "CHIRP", "CHIRR", "CHIRU", "CHITS", "CHIVE", "CHIVY", "CHOCK", "CHOIR", "CHOKE", "CHOKY", "CHOLA", "CHOLO", "CHOMP",
        "CHOOK", "CHOPS", "CHORD", "CHORE", "CHOSE", "CHOTT", "CHOWS", "CHUBS", "CHUCK", "CHUFA", "CHUFF", "CHUGS", "CHUMP", "CHUMS", "CHUNK", "CHURL", "CHURN",
        "CHURR", "CHUTE", "CHYLE", "CHYME", "CIBOL", "CIDER", "CIGAR", "CILIA", "CIMEX", "CINCH", "CINES", "CIONS", "CIRCA", "CIRES", "CIRRI", "CISCO", "CISSY",
        "CISTS", "CITED", "CITER", "CITES", "CIVET", "CIVIC", "CIVIE", "CIVIL", "CIVVY", "CLACH", "CLACK", "CLADE", "CLADS", "CLAGS", "CLAIM", "CLAMP", "CLAMS",
        "CLANG", "CLANK", "CLANS", "CLAPS", "CLAPT", "CLARO", "CLARY", "CLASH", "CLASP", "CLASS", "CLAST", "CLAVE", "CLAVI", "CLAWS", "CLAYS", "CLEAN", "CLEAR",
        "CLEAT", "CLEEK", "CLEFS", "CLEFT", "CLEPE", "CLEPT", "CLERK", "CLEWS", "CLICK", "CLIFF", "CLIFT", "CLIMB", "CLIME", "CLINE", "CLING", "CLINK", "CLIPS",
        "CLIPT", "CLOAK", "CLOCK", "CLODS", "CLOGS", "CLOMB", "CLOMP", "CLONE", "CLONK", "CLONS", "CLOOT", "CLOPS", "CLOSE", "CLOTH", "CLOTS", "CLOUD", "CLOUR",
        "CLOUT", "CLOVE", "CLOWN", "CLOYS", "CLOZE", "CLUBS", "CLUCK", "CLUED", "CLUES", "CLUMP", "CLUNG", "CLUNK", "CNIDA", "COACH", "COACT", "COALA", "COALS",
        "COALY", "COAPT", "COAST", "COATI", "COATS", "COBBS", "COBBY", "COBIA", "COBLE", "COBRA", "COCAS", "COCCI", "COCKS", "COCKY", "COCOA", "COCOS", "CODAS",
        "CODEC", "CODED", "CODEN", "CODER", "CODES", "CODEX", "CODON", "COEDS", "COFFS", "COGON", "COHOG", "COHOS", "COIFS", "COIGN", "COILS", "COINS", "COIRS",
        "COKED", "COKES", "COLAS", "COLBY", "COLDS", "COLED", "COLES", "COLIC", "COLIN", "COLLY", "COLOG", "COLON", "COLOR", "COLTS", "COLZA", "COMAE", "COMAL",
        "COMAS", "COMBE", "COMBO", "COMBS", "COMER", "COMES", "COMET", "COMFY", "COMIC", "COMIX", "COMMA", "COMMY", "COMPO", "COMPS", "COMPT", "COMTE", "CONCH",
        "CONDO", "CONED", "CONES", "CONEY", "CONGA", "CONGE", "CONGO", "CONIC", "CONIN", "CONKS", "CONKY", "CONNS", "CONTE", "CONTO", "CONUS", "COOCH", "COOED",
        "COOEE", "COOER", "COOEY", "COOFS", "COOKS", "COOKY", "COOLS", "COOLY", "COOMB", "COONS", "COOPS", "COOPT", "COOTS", "COPAL", "COPAY", "COPED", "COPEN",
        "COPER", "COPES", "COPRA", "COPSE", "CORAL", "CORBY", "CORDS", "CORED", "CORER", "CORES", "CORGI", "CORIA", "CORKS", "CORKY", "CORMS", "CORNS", "CORNU",
        "CORNY", "CORPS", "CORSE", "COSEC", "COSES", "COSET", "COSEY", "COSIE", "COSTA", "COSTS", "COTAN", "COTED", "COTES", "COTTA", "COUCH", "COUDE", "COUGH",
        "COULD", "COUNT", "COUPE", "COUPS", "COURT", "COUTH", "COVED", "COVEN", "COVER", "COVES", "COVET", "COVEY", "COVIN", "COWED", "COWER", "COWLS", "COWRY",
        "COXAE", "COXAL", "COXED", "COXES", "COYED", "COYER", "COYLY", "COYPU", "COZEN", "COZES", "COZEY", "COZIE", "CRAAL", "CRABS", "CRACK", "CRAFT", "CRAGS",
        "CRAKE", "CRAMP", "CRAMS", "CRANE", "CRANK", "CRAPE", "CRAPS", "CRASH", "CRASS", "CRATE", "CRAVE", "CRAWL", "CRAWS", "CRAZE", "CRAZY", "CREAK", "CREAM",
        "CREDO", "CREDS", "CREED", "CREEK", "CREEL", "CREEP", "CREME", "CREPE", "CREPT", "CREPY", "CRESS", "CREST", "CREWS", "CRIBS", "CRICK", "CRIED", "CRIER",
        "CRIES", "CRIME", "CRIMP", "CRIPE", "CRISP", "CRITS", "CROAK", "CROCI", "CROCK", "CROCS", "CROFT", "CRONE", "CRONY", "CROOK", "CROON", "CROPS", "CRORE",
        "CROSS", "CROUP", "CROWD", "CROWN", "CROWS", "CROZE", "CRUCK", "CRUDE", "CRUDS", "CRUEL", "CRUET", "CRUMB", "CRUMP", "CRUOR", "CRURA", "CRUSE", "CRUSH",
        "CRUST", "CRWTH", "CRYPT", "CUBBY", "CUBEB", "CUBED", "CUBER", "CUBES", "CUBIC", "CUBIT", "CUDDY", "CUFFS", "CUIFS", "CUING", "CUISH", "CUKES", "CULCH",
        "CULET", "CULEX", "CULLS", "CULLY", "CULMS", "CULPA", "CULTI", "CULTS", "CUMIN", "CUPEL", "CUPID", "CUPPA", "CUPPY", "CURBS", "CURCH", "CURDS", "CURDY",
        "CURED", "CURER", "CURES", "CURET", "CURFS", "CURIA", "CURIE", "CURIO", "CURLS", "CURLY", "CURNS", "CURRS", "CURRY", "CURSE", "CURST", "CURVE", "CURVY",
        "CUSEC", "CUSHY", "CUSKS", "CUSPS", "CUSSO", "CUTCH", "CUTER", "CUTES", "CUTEY", "CUTIE", "CUTIN", "CUTIS", "CUTTY", "CUTUP", "CUVEE", "CYANO", "CYANS",
        "CYBER", "CYCAD", "CYCAS", "CYCLE", "CYCLO", "CYDER", "CYLIX", "CYMAE", "CYMAR", "CYMAS", "CYMES", "CYMOL", "CYNIC", "CYSTS", "CYTON", "CZARS"
    };
    public static List<string> FiveLetter_D = new List<string>()
    {
        "DACES", "DACHA", "DADAS", "DADDY", "DADOS", "DAFFS", "DAFFY", "DAGGA", "DAGOS", "DAHLS", "DAILY", "DAIRY", "DAISY", "DALES", "DALLY", "DAMAN", "DAMAR",
        "DAMES", "DAMNS", "DAMPS", "DANCE", "DANDY", "DANGS", "DANIO", "DARBS", "DARED", "DARER", "DARES", "DARIC", "DARKS", "DARKY", "DARNS", "DARTS", "DASHI",
        "DASHY", "DATED", "DATER", "DATES", "DATOS", "DATTO", "DATUM", "DAUBE", "DAUBS", "DAUBY", "DAUNT", "DAUTS", "DAVEN", "DAVIT", "DAWED", "DAWEN", "DAWKS",
        "DAWNS", "DAWTS", "DAZED", "DAZES", "DEADS", "DEAIR", "DEALS", "DEALT", "DEANS", "DEARS", "DEARY", "DEASH", "DEATH", "DEAVE", "DEBAG", "DEBAR", "DEBIT",
        "DEBTS", "DEBUG", "DEBUT", "DEBYE", "DECAF", "DECAL", "DECAY", "DECKS", "DECOR", "DECOS", "DECOY", "DECRY", "DEDAL", "DEEDS", "DEEDY", "DEEMS", "DEEPS",
        "DEERS", "DEETS", "DEFAT", "DEFER", "DEFIS", "DEFOG", "DEGAS", "DEGUM", "DEICE", "DEIFY", "DEIGN", "DEILS", "DEISM", "DEIST", "DEITY", "DEKED", "DEKES",
        "DEKKO", "DELAY", "DELED", "DELES", "DELFS", "DELFT", "DELIS", "DELLS", "DELLY", "DELTA", "DELTS", "DELVE", "DEMES", "DEMIC", "DEMIT", "DEMOB", "DEMON",
        "DEMOS", "DEMUR", "DENAR", "DENES", "DENIM", "DENSE", "DENTS", "DEOXY", "DEPOT", "DEPTH", "DERAT", "DERAY", "DERBY", "DERMA", "DERMS", "DERRY", "DESEX",
        "DESKS", "DETER", "DETOX", "DEUCE", "DEVAS", "DEVEL", "DEVIL", "DEVON", "DEWAN", "DEWAR", "DEWAX", "DEWED", "DEXES", "DEXIE", "DHAKS", "DHALS", "DHOBI",
        "DHOLE", "DHOTI", "DHOWS", "DHUTI", "DIALS", "DIARY", "DIAZO", "DICED", "DICER", "DICES", "DICEY", "DICKS", "DICKY", "DICOT", "DICTA", "DICTY", "DIDIE",
        "DIDOS", "DIDST", "DIENE", "DIETS", "DIFFS", "DIGHT", "DIGIT", "DIKED", "DIKER", "DIKES", "DIKEY", "DILDO", "DILLS", "DILLY", "DIMER", "DIMES", "DIMLY",
        "DINAR", "DINED", "DINER", "DINES", "DINGE", "DINGO", "DINGS", "DINGY", "DINKY", "DINOS", "DINTS", "DIODE", "DIOLS", "DIPPY", "DIPSO", "DIRAM", "DIRER",
        "DIRGE", "DIRKS", "DIRLS", "DIRTS", "DISCI", "DISCO", "DISCS", "DISHY", "DISKS", "DISME", "DITAS", "DITCH", "DITES", "DITSY", "DITTO", "DITTY", "DITZY",
        "DIVAN", "DIVAS", "DIVED", "DIVER", "DIVES", "DIVOT", "DIVVY", "DIWAN", "DIXIT", "DIZEN", "DIZZY", "DJINN", "DJINS", "DOATS", "DOBBY", "DOBIE", "DOBLA",
        "DOBRA", "DOBRO", "DOCKS", "DODGE", "DODGY", "DODOS", "DOERS", "DOEST", "DOETH", "DOFFS", "DOGES", "DOGEY", "DOGGO", "DOGGY", "DOGIE", "DOGMA", "DOILY",
        "DOING", "DOITS", "DOJOS", "DOLCE", "DOLCI", "DOLED", "DOLES", "DOLLS", "DOLLY", "DOLMA", "DOLOR", "DOLTS", "DOMAL", "DOMED", "DOMES", "DOMIC", "DONAS",
        "DONEE", "DONGA", "DONGS", "DONNA", "DONNE", "DONOR", "DONSY", "DONUT", "DOODY", "DOOLY", "DOOMS", "DOOMY", "DOORS", "DOOZY", "DOPAS", "DOPED", "DOPER",
        "DOPES", "DOPEY", "DORKS", "DORKY", "DORMS", "DORMY", "DORPS", "DORRS", "DORSA", "DORTY", "DOSED", "DOSER", "DOSES", "DOTAL", "DOTED", "DOTER", "DOTES",
        "DOTTY", "DOUBT", "DOUCE", "DOUGH", "DOULA", "DOUMA", "DOUMS", "DOURA", "DOUSE", "DOVEN", "DOVES", "DOWDY", "DOWED", "DOWEL", "DOWER", "DOWIE", "DOWNS",
        "DOWNY", "DOWRY", "DOWSE", "DOXIE", "DOYEN", "DOYLY", "DOZED", "DOZEN", "DOZER", "DOZES", "DRABS", "DRAFF", "DRAFT", "DRAGS", "DRAIL", "DRAIN", "DRAKE",
        "DRAMA", "DRAMS", "DRANK", "DRAPE", "DRATS", "DRAVE", "DRAWL", "DRAWN", "DRAWS", "DRAYS", "DREAD", "DREAM", "DREAR", "DRECK", "DREED", "DREES", "DREGS",
        "DREKS", "DRESS", "DREST", "DRIBS", "DRIED", "DRIER", "DRIES", "DRIFT", "DRILL", "DRILY", "DRINK", "DRIPS", "DRIPT", "DRIVE", "DROID", "DROIT", "DROLL",
        "DRONE", "DROOL", "DROOP", "DROPS", "DROPT", "DROSS", "DROUK", "DROVE", "DROWN", "DRUBS", "DRUGS", "DRUID", "DRUMS", "DRUNK", "DRUPE", "DRUSE", "DRYAD",
        "DRYER", "DRYLY", "DUADS", "DUALS", "DUCAL", "DUCAT", "DUCES", "DUCHY", "DUCKS", "DUCKY", "DUCTS", "DUDDY", "DUDED", "DUDES", "DUELS", "DUETS", "DUFFS",
        "DUFUS", "DUITS", "DUKED", "DUKES", "DULIA", "DULLS", "DULLY", "DULSE", "DUMAS", "DUMBS", "DUMKA", "DUMKY", "DUMPS", "DUMPY", "DUNAM", "DUNCE", "DUNCH",
        "DUNES", "DUNGS", "DUNGY", "DUNKS", "DUNTS", "DUOMI", "DUOMO", "DUPED", "DUPER", "DUPES", "DUPLE", "DURAL", "DURAS", "DURED", "DURES", "DURNS", "DUROC",
        "DUROS", "DURRA", "DURRS", "DURST", "DURUM", "DUSKS", "DUSKY", "DUSTS", "DUSTY", "DUTCH", "DUVET", "DWARF", "DWEEB", "DWELL", "DWELT", "DWINE", "DYADS",
        "DYERS", "DYING", "DYKED", "DYKES", "DYKEY", "DYNEL", "DYNES"
    };
    public static List<string> FiveLetter_E = new List<string>()
    {
        "EAGER", "EAGLE", "EAGRE", "EARED", "EARLS", "EARLY", "EARNS", "EARTH", "EASED", "EASEL", "EASES", "EASTS", "EATEN", "EATER", "EAVED", "EAVES", "EBBED",
        "EBBET", "EBONS", "EBONY", "EBOOK", "ECHED", "ECHES", "ECHOS", "ECLAT", "ECRUS", "EDEMA", "EDGED", "EDGER", "EDGES", "EDICT", "EDIFY", "EDILE", "EDITS",
        "EDUCE", "EDUCT", "EERIE", "EGADS", "EGERS", "EGEST", "EGGAR", "EGGED", "EGGER", "EGRET", "EIDER", "EIDOS", "EIGHT", "EIKON", "EJECT", "EKING", "ELAIN",
        "ELAND", "ELANS", "ELATE", "ELBOW", "ELDER", "ELECT", "ELEGY", "ELEMI", "ELFIN", "ELIDE", "ELINT", "ELITE", "ELOIN", "ELOPE", "ELUDE", "ELUTE", "ELVER",
        "ELVES", "EMAIL", "EMBAR", "EMBAY", "EMBED", "EMBER", "EMBOW", "EMCEE", "EMEER", "EMEND", "EMERY", "EMEUS", "EMIRS", "EMITS", "EMMER", "EMMET", "EMMYS",
        "EMOTE", "EMPTY", "EMYDE", "EMYDS", "ENACT", "ENATE", "ENDED", "ENDER", "ENDOW", "ENDUE", "ENEMA", "ENEMY", "ENJOY", "ENNUI", "ENOKI", "ENOLS", "ENORM",
        "ENOWS", "ENROL", "ENSKY", "ENSUE", "ENTER", "ENTIA", "ENTRY", "ENURE", "ENVOI", "ENVOY", "ENZYM", "EOSIN", "EPACT", "EPEES", "EPHAH", "EPHAS", "EPHOD",
        "EPHOR", "EPICS", "EPOCH", "EPODE", "EPOXY", "EQUAL", "EQUID", "EQUIP", "ERASE", "ERGOT", "ERICA", "ERNES", "ERODE", "EROSE", "ERRED", "ERROR", "ERSES",
        "ERUCT", "ERUGO", "ERUPT", "ERVIL", "ESCAR", "ESCOT", "ESKAR", "ESKER", "ESNES", "ESSAY", "ESSES", "ESTER", "ESTOP", "ETAPE", "ETHER", "ETHIC", "ETHOS",
        "ETHYL", "ETNAS", "ETUDE", "ETUIS", "ETWEE", "ETYMA", "EUROS", "EVADE", "EVENS", "EVENT", "EVERT", "EVERY", "EVICT", "EVILS", "EVITE", "EVOKE", "EWERS",
        "EXACT", "EXALT", "EXAMS", "EXCEL", "EXECS", "EXERT", "EXILE", "EXINE", "EXING", "EXIST", "EXITS", "EXONS", "EXPAT", "EXPEL", "EXPOS", "EXTOL", "EXTRA",
        "EXUDE", "EXULT", "EXURB", "EYASS", "EYERS", "EYING", "EYRAS", "EYRES", "EYRIE", "EYRIR"
    };
    public static List<string> FiveLetter_F = new List<string>()
    {
        "FABLE", "FACED", "FACER", "FACES", "FACET", "FACIA", "FACTS", "FADDY", "FADED", "FADER", "FADES", "FADGE", "FADOS", "FAENA", "FAERY", "FAGGY", "FAGIN",
        "FAGOT", "FAILS", "FAINT", "FAIRS", "FAIRY", "FAITH", "FAKED", "FAKER", "FAKES", "FAKEY", "FAKIR", "FALLS", "FALSE", "FAMED", "FAMES", "FANCY", "FANES",
        "FANGA", "FANGS", "FANNY", "FANON", "FANOS", "FANUM", "FAQIR", "FARAD", "FARCE", "FARCI", "FARCY", "FARDS", "FARED", "FARER", "FARES", "FARLE", "FARLS",
        "FARMS", "FAROS", "FARTS", "FASTS", "FATAL", "FATED", "FATES", "FATLY", "FATSO", "FATTY", "FATWA", "FAUGH", "FAULD", "FAULT", "FAUNA", "FAUNS", "FAUVE",
        "FAVAS", "FAVES", "FAVOR", "FAVUS", "FAWNS", "FAWNY", "FAXED", "FAXES", "FAYED", "FAZED", "FAZES", "FEARS", "FEASE", "FEAST", "FEATS", "FEAZE", "FECAL",
        "FECES", "FECKS", "FEDEX", "FEEBS", "FEEDS", "FEELS", "FEEZE", "FEIGN", "FEINT", "FEIST", "FELID", "FELLA", "FELLS", "FELLY", "FELON", "FELTS", "FEMES",
        "FEMME", "FEMUR", "FENCE", "FENDS", "FENNY", "FEODS", "FEOFF", "FERAL", "FERES", "FERIA", "FERLY", "FERMI", "FERNS", "FERNY", "FERRY", "FESSE", "FESTS",
        "FETAL", "FETAS", "FETCH", "FETED", "FETES", "FETID", "FETOR", "FETUS", "FEUAR", "FEUDS", "FEUED", "FEVER", "FEWER", "FEYER", "FEYLY", "FEZES", "FEZZY",
        "FIARS", "FIATS", "FIBER", "FIBRE", "FICES", "FICHE", "FICHU", "FICIN", "FICUS", "FIDGE", "FIDOS", "FIEFS", "FIELD", "FIEND", "FIERY", "FIFED", "FIFER",
        "FIFES", "FIFTH", "FIFTY", "FIGHT", "FILAR", "FILCH", "FILED", "FILER", "FILES", "FILET", "FILLE", "FILLO", "FILLS", "FILLY", "FILMI", "FILMS", "FILMY",
        "FILOS", "FILTH", "FILUM", "FINAL", "FINCA", "FINCH", "FINDS", "FINED", "FINER", "FINES", "FINIS", "FINKS", "FINNY", "FINOS", "FIORD", "FIQUE", "FIRED",
        "FIRER", "FIRES", "FIRMS", "FIRNS", "FIRRY", "FIRST", "FIRTH", "FISCS", "FISHY", "FISTS", "FITCH", "FITLY", "FIVER", "FIVES", "FIXED", "FIXER", "FIXES",
        "FIXIT", "FIZZY", "FJELD", "FJORD", "FLABS", "FLACK", "FLAGS", "FLAIL", "FLAIR", "FLAKE", "FLAKY", "FLAME", "FLAMS", "FLAMY", "FLANK", "FLANS", "FLAPS",
        "FLARE", "FLASH", "FLASK", "FLATS", "FLAWS", "FLAWY", "FLAXY", "FLAYS", "FLEAM", "FLEAS", "FLECK", "FLEER", "FLEES", "FLEET", "FLESH", "FLEWS", "FLEYS",
        "FLICK", "FLICS", "FLIED", "FLIER", "FLIES", "FLING", "FLINT", "FLIPS", "FLIRS", "FLIRT", "FLITE", "FLITS", "FLOAT", "FLOCK", "FLOCS", "FLOES", "FLOGS",
        "FLONG", "FLOOD", "FLOOR", "FLOPS", "FLORA", "FLOSS", "FLOTA", "FLOUR", "FLOUT", "FLOWN", "FLOWS", "FLUBS", "FLUED", "FLUES", "FLUFF", "FLUID", "FLUKE",
        "FLUKY", "FLUME", "FLUMP", "FLUNG", "FLUNK", "FLUOR", "FLUSH", "FLUTE", "FLUTY", "FLUYT", "FLYBY", "FLYER", "FLYTE", "FOALS", "FOAMS", "FOAMY", "FOCAL",
        "FOCUS", "FOEHN", "FOGEY", "FOGGY", "FOGIE", "FOHNS", "FOILS", "FOINS", "FOIST", "FOLDS", "FOLEY", "FOLIA", "FOLIC", "FOLIO", "FOLKS", "FOLKY", "FOLLY",
        "FONDS", "FONDU", "FONTS", "FOODS", "FOOLS", "FOOTS", "FOOTY", "FORAM", "FORAY", "FORBS", "FORBY", "FORCE", "FORDO", "FORDS", "FORES", "FORGE", "FORGO",
        "FORKS", "FORKY", "FORME", "FORMS", "FORTE", "FORTH", "FORTS", "FORTY", "FORUM", "FOSSA", "FOSSE", "FOULS", "FOUND", "FOUNT", "FOURS", "FOVEA", "FOWLS",
        "FOXED", "FOXES", "FOYER", "FRAGS", "FRAIL", "FRAME", "FRANC", "FRANK", "FRAPS", "FRASS", "FRATS", "FRAUD", "FRAYS", "FREAK", "FREED", "FREER", "FREES",
        "FREMD", "FRENA", "FRERE", "FRESH", "FRETS", "FRIAR", "FRIED", "FRIER", "FRIES", "FRIGS", "FRILL", "FRISE", "FRISK", "FRITH", "FRITS", "FRITT", "FRITZ",
        "FRIZZ", "FROCK", "FROES", "FROGS", "FROND", "FRONS", "FRONT", "FRORE", "FROSH", "FROST", "FROTH", "FROWN", "FROWS", "FROZE", "FRUGS", "FRUIT", "FRUMP",
        "FRYER", "FUBAR", "FUBSY", "FUCUS", "FUDDY", "FUDGE", "FUELS", "FUGAL", "FUGGY", "FUGIO", "FUGLE", "FUGUE", "FUGUS", "FUJIS", "FULLS", "FULLY", "FUMED",
        "FUMER", "FUMES", "FUMET", "FUNDI", "FUNDS", "FUNGI", "FUNGO", "FUNKS", "FUNKY", "FUNNY", "FURAN", "FURLS", "FUROR", "FURRY", "FURZE", "FURZY", "FUSED",
        "FUSEE", "FUSEL", "FUSES", "FUSIL", "FUSSY", "FUSTY", "FUTON", "FUZED", "FUZEE", "FUZES", "FUZIL", "FUZZY", "FYCES", "FYKES", "FYTTE"
    };
    public static List<string> FiveLetter_G = new List<string>()
    {
        "GABBY", "GABLE", "GADDI", "GADID", "GADIS", "GADJE", "GADJO", "GAFFE", "GAFFS", "GAGED", "GAGER", "GAGES", "GAILY", "GAINS", "GAITS", "GALAH", "GALAS",
        "GALAX", "GALEA", "GALES", "GALLS", "GALLY", "GALOP", "GAMAS", "GAMAY", "GAMBA", "GAMBE", "GAMBS", "GAMED", "GAMER", "GAMES", "GAMEY", "GAMIC", "GAMIN",
        "GAMMA", "GAMMY", "GAMPS", "GAMUT", "GANEF", "GANEV", "GANGS", "GANJA", "GANOF", "GAOLS", "GAPED", "GAPER", "GAPES", "GAPPY", "GARBS", "GARDA", "GARNI",
        "GARTH", "GASES", "GASPS", "GASSY", "GASTS", "GATED", "GATER", "GATES", "GATOR", "GAUDS", "GAUDY", "GAUGE", "GAULT", "GAUMS", "GAUNT", "GAURS", "GAUSS",
        "GAUZE", "GAUZY", "GAVEL", "GAVOT", "GAWKS", "GAWKY", "GAWPS", "GAWSY", "GAYAL", "GAYER", "GAYLY", "GAZAR", "GAZED", "GAZER", "GAZES", "GAZOO", "GEARS",
        "GECKO", "GECKS", "GEEKS", "GEEKY", "GEESE", "GEEST", "GELDS", "GELEE", "GELID", "GELTS", "GEMMA", "GEMMY", "GEMOT", "GENES", "GENET", "GENIC", "GENIE",
        "GENII", "GENIP", "GENOA", "GENOM", "GENRE", "GENRO", "GENTS", "GENUA", "GENUS", "GEODE", "GEOID", "GERAH", "GERMS", "GERMY", "GESSO", "GESTE", "GESTS",
        "GETAS", "GETUP", "GEUMS", "GHAST", "GHATS", "GHAUT", "GHAZI", "GHEES", "GHOST", "GHOUL", "GHYLL", "GIANT", "GIBED", "GIBER", "GIBES", "GIDDY", "GIFTS",
        "GIGAS", "GIGHE", "GIGOT", "GIGUE", "GILDS", "GILLS", "GILLY", "GILTS", "GIMEL", "GIMME", "GIMPS", "GIMPY", "GINKS", "GINNY", "GINZO", "GIPON", "GIPSY",
        "GIRDS", "GIRLS", "GIRLY", "GIRNS", "GIRON", "GIROS", "GIRSH", "GIRTH", "GIRTS", "GISMO", "GISTS", "GITES", "GIVEN", "GIVER", "GIVES", "GIZMO", "GLACE",
        "GLADE", "GLADS", "GLADY", "GLAIR", "GLAMS", "GLAND", "GLANS", "GLARE", "GLARY", "GLASS", "GLAZE", "GLAZY", "GLEAM", "GLEAN", "GLEBA", "GLEBE", "GLEDE",
        "GLEDS", "GLEED", "GLEEK", "GLEES", "GLEET", "GLENS", "GLEYS", "GLIAL", "GLIAS", "GLIDE", "GLIFF", "GLIME", "GLIMS", "GLINT", "GLITZ", "GLOAM", "GLOAT",
        "GLOBE", "GLOBS", "GLOGG", "GLOMS", "GLOOM", "GLOPS", "GLORY", "GLOSS", "GLOST", "GLOUT", "GLOVE", "GLOWS", "GLOZE", "GLUED", "GLUER", "GLUES", "GLUEY",
        "GLUGS", "GLUME", "GLUMS", "GLUON", "GLUTE", "GLUTS", "GLYPH", "GNARL", "GNARR", "GNARS", "GNASH", "GNATS", "GNAWN", "GNAWS", "GNOME", "GOADS", "GOALS",
        "GOATS", "GOBAN", "GOBOS", "GODET", "GODLY", "GOERS", "GOFER", "GOGOS", "GOING", "GOLDS", "GOLEM", "GOLFS", "GOLLY", "GOMBO", "GOMER", "GONAD", "GONEF",
        "GONER", "GONGS", "GONIA", "GONIF", "GONOF", "GONZO", "GOODS", "GOODY", "GOOEY", "GOOFS", "GOOFY", "GOOKS", "GOOKY", "GOONS", "GOONY", "GOOPS", "GOOPY",
        "GOOSE", "GOOSY", "GOPIK", "GORAL", "GORED", "GORES", "GORGE", "GORMS", "GORPS", "GORSE", "GORSY", "GOTHS", "GOUGE", "GOURD", "GOUTS", "GOUTY", "GOWAN",
        "GOWDS", "GOWKS", "GOWNS", "GOXES", "GOYIM", "GRAAL", "GRABS", "GRACE", "GRADE", "GRADS", "GRAFT", "GRAIL", "GRAIN", "GRAMA", "GRAMP", "GRAMS", "GRANA",
        "GRAND", "GRANS", "GRANT", "GRAPE", "GRAPH", "GRAPY", "GRASP", "GRASS", "GRATE", "GRAVE", "GRAVY", "GRAYS", "GRAZE", "GREAT", "GREBE", "GREED", "GREEK",
        "GREEN", "GREES", "GREET", "GREGO", "GREYS", "GRIDE", "GRIDS", "GRIEF", "GRIFF", "GRIFT", "GRIGS", "GRILL", "GRIME", "GRIMY", "GRIND", "GRINS", "GRIOT",
        "GRIPE", "GRIPS", "GRIPT", "GRIPY", "GRIST", "GRITH", "GRITS", "GROAN", "GROAT", "GRODY", "GROGS", "GROIN", "GROKS", "GROOM", "GROPE", "GROSS", "GROSZ",
        "GROTS", "GROUP", "GROUT", "GROVE", "GROWL", "GROWN", "GROWS", "GRUBS", "GRUEL", "GRUES", "GRUFF", "GRUME", "GRUMP", "GRUNT", "GUACO", "GUANO", "GUANS",
        "GUARD", "GUARS", "GUAVA", "GUCKS", "GUDES", "GUESS", "GUEST", "GUFFS", "GUIDE", "GUIDS", "GUILD", "GUILE", "GUILT", "GUIRO", "GUISE", "GULAG", "GULAR",
        "GULCH", "GULES", "GULFS", "GULFY", "GULLS", "GULLY", "GULPS", "GULPY", "GUMBO", "GUMMA", "GUMMY", "GUNKS", "GUNKY", "GUNNY", "GUPPY", "GURGE", "GURRY",
        "GURSH", "GURUS", "GUSHY", "GUSSY", "GUSTO", "GUSTS", "GUSTY", "GUTSY", "GUTTA", "GUTTY", "GUYED", "GUYOT", "GWINE", "GYBED", "GYBES", "GYOZA", "GYPSY",
        "GYRAL", "GYRED", "GYRES", "GYRON", "GYROS", "GYRUS", "GYVED", "GYVES"
    };
    public static List<string> FiveLetter_H = new List<string>()
    {
        "HAAFS", "HAARS", "HABIT", "HABUS", "HACEK", "HACKS", "HADAL", "HADED", "HADES", "HADJI", "HADST", "HAEMS", "HAETS", "HAFIZ", "HAFTS", "HAHAS", "HAIKA",
        "HAIKS", "HAIKU", "HAILS", "HAINT", "HAIRS", "HAIRY", "HAJES", "HAJIS", "HAJJI", "HAKES", "HAKIM", "HAKUS", "HALAL", "HALED", "HALER", "HALES", "HALID",
        "HALLO", "HALLS", "HALMA", "HALMS", "HALON", "HALOS", "HALTS", "HALVA", "HALVE", "HAMAL", "HAMES", "HAMMY", "HAMZA", "HANCE", "HANDS", "HANDY", "HANGS",
        "HANKS", "HANKY", "HANSA", "HANSE", "HANTS", "HAOLE", "HAPAX", "HAPLY", "HAPPY", "HARDS", "HARDY", "HARED", "HAREM", "HARES", "HARKS", "HARLS", "HARMS",
        "HARPS", "HARPY", "HARRY", "HARSH", "HARTS", "HASPS", "HASTE", "HASTY", "HATCH", "HATED", "HATER", "HATES", "HAUGH", "HAULM", "HAULS", "HAUNT", "HAUTE",
        "HAVEN", "HAVER", "HAVES", "HAVOC", "HAWED", "HAWKS", "HAWSE", "HAYED", "HAYER", "HAYEY", "HAZAN", "HAZED", "HAZEL", "HAZER", "HAZES", "HEADS", "HEADY",
        "HEALS", "HEAPS", "HEAPY", "HEARD", "HEARS", "HEART", "HEATH", "HEATS", "HEAVE", "HEAVY", "HEBES", "HECKS", "HEDER", "HEDGE", "HEDGY", "HEEDS", "HEELS",
        "HEEZE", "HEFTS", "HEFTY", "HEIGH", "HEILS", "HEIRS", "HEIST", "HELIO", "HELIX", "HELLO", "HELLS", "HELMS", "HELOS", "HELOT", "HELPS", "HELVE", "HEMAL",
        "HEMES", "HEMIC", "HEMIN", "HEMPS", "HEMPY", "HENCE", "HENGE", "HENNA", "HENRY", "HENTS", "HERBS", "HERBY", "HERDS", "HERES", "HERLS", "HERMA", "HERMS",
        "HERNS", "HERON", "HEROS", "HERRY", "HERTZ", "HESTS", "HETHS", "HEUCH", "HEUGH", "HEWED", "HEWER", "HEXAD", "HEXED", "HEXER", "HEXES", "HEXYL", "HICKS",
        "HIDED", "HIDER", "HIDES", "HIGHS", "HIGHT", "HIJAB", "HIJRA", "HIKED", "HIKER", "HIKES", "HILAR", "HILLO", "HILLS", "HILLY", "HILTS", "HILUM", "HILUS",
        "HINDS", "HINGE", "HINKY", "HINNY", "HINTS", "HIPLY", "HIPPO", "HIPPY", "HIRED", "HIREE", "HIRER", "HIRES", "HISSY", "HISTS", "HITCH", "HIVED", "HIVES",
        "HOAGY", "HOARD", "HOARS", "HOARY", "HOBBY", "HOBOS", "HOCKS", "HOCUS", "HODAD", "HOERS", "HOGAN", "HOGGS", "HOICK", "HOISE", "HOIST", "HOKED", "HOKES",
        "HOKEY", "HOKKU", "HOKUM", "HOLDS", "HOLED", "HOLES", "HOLEY", "HOLKS", "HOLLA", "HOLLO", "HOLLY", "HOLMS", "HOLTS", "HOMED", "HOMER", "HOMES", "HOMEY",
        "HOMIE", "HONAN", "HONDA", "HONED", "HONER", "HONES", "HONEY", "HONGI", "HONGS", "HONKS", "HONOR", "HOOCH", "HOODS", "HOODY", "HOOEY", "HOOFS", "HOOKA",
        "HOOKS", "HOOKY", "HOOLY", "HOOPS", "HOOTS", "HOOTY", "HOPED", "HOPER", "HOPES", "HOPPY", "HORAH", "HORAL", "HORAS", "HORDE", "HORNS", "HORNY", "HORSE",
        "HORST", "HORSY", "HOSED", "HOSEL", "HOSEN", "HOSER", "HOSES", "HOSEY", "HOSTA", "HOSTS", "HOTCH", "HOTEL", "HOTLY", "HOUND", "HOURI", "HOURS", "HOUSE",
        "HOVEL", "HOVER", "HOWDY", "HOWES", "HOWFF", "HOWFS", "HOWKS", "HOWLS", "HOYAS", "HOYLE", "HUBBY", "HUCKS", "HUFFS", "HUFFY", "HUGER", "HULAS", "HULKS",
        "HULKY", "HULLO", "HULLS", "HUMAN", "HUMIC", "HUMID", "HUMOR", "HUMPH", "HUMPS", "HUMPY", "HUMUS", "HUNCH", "HUNKS", "HUNKY", "HUNTS", "HURDS", "HURLS",
        "HURLY", "HURRY", "HURST", "HURTS", "HUSKS", "HUSKY", "HUSSY", "HUTCH", "HUZZA", "HYDRA", "HYDRO", "HYENA", "HYING", "HYLAS", "HYMEN", "HYMNS", "HYOID",
        "HYPED", "HYPER", "HYPES", "HYPHA", "HYPOS", "HYRAX", "HYSON"
    };
    public static List<string> FiveLetter_I = new List<string>()
    {
        "IAMBI", "IAMBS", "ICHOR", "ICIER", "ICILY", "ICING", "ICKER", "ICONS", "ICTIC", "ICTUS", "IDEAL", "IDEAS", "IDIOM", "IDIOT", "IDLED", "IDLER", "IDLES",
        "IDOLS", "IDYLL", "IDYLS", "IGGED", "IGLOO", "IGLUS", "IHRAM", "IKATS", "IKONS", "ILEAC", "ILEAL", "ILEUM", "ILEUS", "ILIAC", "ILIAD", "ILIAL", "ILIUM",
        "ILLER", "IMAGE", "IMAGO", "IMAMS", "IMAUM", "IMBED", "IMBUE", "IMIDE", "IMIDO", "IMIDS", "IMINE", "IMINO", "IMMIX", "IMPED", "IMPEL", "IMPIS", "IMPLY",
        "INANE", "INAPT", "INARM", "INBYE", "INCOG", "INCUR", "INCUS", "INDEX", "INDIE", "INDOL", "INDOW", "INDRI", "INDUE", "INEPT", "INERT", "INFER", "INFIX",
        "INFOS", "INFRA", "INGLE", "INGOT", "INION", "INKED", "INKER", "INKLE", "INLAY", "INLET", "INNED", "INNER", "INPUT", "INRUN", "INSET", "INTER", "INTIS",
        "INTRO", "INURE", "INURN", "INVAR", "IODIC", "IODID", "IODIN", "IONIC", "IOTAS", "IRADE", "IRATE", "IRIDS", "IRING", "IRKED", "IROKO", "IRONE", "IRONS",
        "IRONY", "ISBAS", "ISLED", "ISLES", "ISLET", "ISSEI", "ISSUE", "ISTLE", "ITCHY", "ITEMS", "ITHER", "IVIED", "IVIES", "IVORY", "IXIAS", "IXORA", "IXTLE",
        "IZARS"
    };
    public static List<string> FiveLetter_J = new List<string>()
    {
        "JABOT", "JACAL", "JACKS", "JACKY", "JADED", "JADES", "JAGER", "JAGGS", "JAGGY", "JAGRA", "JAILS", "JAKES", "JALAP", "JALOP", "JAMBE", "JAMBS", "JAMMY",
        "JANES", "JANTY", "JAPAN", "JAPED", "JAPER", "JAPES", "JARLS", "JATOS", "JAUKS", "JAUNT", "JAUPS", "JAVAS", "JAWAN", "JAWED", "JAZZY", "JEANS", "JEBEL",
        "JEEPS", "JEERS", "JEFES", "JEHAD", "JEHUS", "JELLO", "JELLS", "JELLY", "JEMMY", "JENNY", "JERID", "JERKS", "JERKY", "JERRY", "JESSE", "JESTS", "JETES",
        "JETON", "JETTY", "JEWED", "JEWEL", "JIBBS", "JIBED", "JIBER", "JIBES", "JIFFS", "JIFFY", "JIGGY", "JIHAD", "JILLS", "JILTS", "JIMMY", "JIMPY", "JINGO",
        "JINKS", "JINNI", "JINNS", "JISMS", "JIVED", "JIVER", "JIVES", "JIVEY", "JNANA", "JOCKO", "JOCKS", "JOEYS", "JOHNS", "JOINS", "JOINT", "JOIST", "JOKED",
        "JOKER", "JOKES", "JOKEY", "JOLES", "JOLLY", "JOLTS", "JOLTY", "JOMON", "JONES", "JORAM", "JORUM", "JOTAS", "JOTTY", "JOUAL", "JOUKS", "JOULE", "JOUST",
        "JOWAR", "JOWED", "JOWLS", "JOWLY", "JOYED", "JUBAS", "JUBES", "JUCOS", "JUDAS", "JUDGE", "JUDOS", "JUGAL", "JUGUM", "JUICE", "JUICY", "JUJUS", "JUKED",
        "JUKES", "JUKUS", "JULEP", "JUMBO", "JUMPS", "JUMPY", "JUNCO", "JUNKS", "JUNKY", "JUNTA", "JUNTO", "JUPES", "JUPON", "JURAL", "JURAT", "JUREL", "JUROR",
        "JUSTS", "JUTES", "JUTTY"
    };
    public static List<string> FiveLetter_K = new List<string>()
    {
        "KABAB", "KABAR", "KABOB", "KADIS", "KAFIR", "KAGUS", "KAIAK", "KAIFS", "KAILS", "KAINS", "KAKAS", "KAKIS", "KALAM", "KALES", "KALIF", "KALPA", "KAMES",
        "KAMIK", "KANAS", "KANES", "KANJI", "KANZU", "KAONS", "KAPAS", "KAPHS", "KAPOK", "KAPPA", "KAPUT", "KARAT", "KARMA", "KARNS", "KAROO", "KARST", "KARTS",
        "KASHA", "KATAS", "KAURI", "KAURY", "KAVAS", "KAYAK", "KAYOS", "KAZOO", "KBARS", "KEBAB", "KEBAR", "KEBOB", "KECKS", "KEDGE", "KEEFS", "KEEKS", "KEELS",
        "KEENS", "KEEPS", "KEETS", "KEEVE", "KEFIR", "KEIRS", "KELEP", "KELIM", "KELLY", "KELPS", "KELPY", "KELTS", "KEMPS", "KEMPT", "KENAF", "KENCH", "KENDO",
        "KENOS", "KENTE", "KEPIS", "KERBS", "KERFS", "KERNE", "KERNS", "KERRY", "KETCH", "KETOL", "KEVEL", "KEVIL", "KEXES", "KEYED", "KHADI", "KHAFS", "KHAKI",
        "KHANS", "KHAPH", "KHATS", "KHEDA", "KHETH", "KHETS", "KHOUM", "KIANG", "KIBBE", "KIBBI", "KIBEI", "KIBES", "KIBLA", "KICKS", "KICKY", "KIDDO", "KIDDY",
        "KIEFS", "KIERS", "KILIM", "KILLS", "KILNS", "KILOS", "KILTS", "KILTY", "KINAS", "KINDS", "KINES", "KINGS", "KININ", "KINKS", "KINKY", "KINOS", "KIOSK",
        "KIRKS", "KIRNS", "KISSY", "KISTS", "KITED", "KITER", "KITES", "KITHE", "KITHS", "KITTY", "KIVAS", "KIWIS", "KLICK", "KLIKS", "KLONG", "KLOOF", "KLUGE",
        "KLUTZ", "KNACK", "KNAPS", "KNARS", "KNAUR", "KNAVE", "KNAWE", "KNEAD", "KNEED", "KNEEL", "KNEES", "KNELL", "KNELT", "KNIFE", "KNISH", "KNITS", "KNOBS",
        "KNOCK", "KNOLL", "KNOPS", "KNOSP", "KNOTS", "KNOUT", "KNOWN", "KNOWS", "KNURL", "KNURS", "KOALA", "KOANS", "KOBOS", "KOELS", "KOHLS", "KOINE", "KOJIS",
        "KOLAS", "KOLOS", "KOMBU", "KONKS", "KOOKS", "KOOKY", "KOPEK", "KOPHS", "KOPJE", "KOPPA", "KORAI", "KORAS", "KORAT", "KORMA", "KORUN", "KOTOS", "KOTOW",
        "KRAAL", "KRAFT", "KRAIT", "KRAUT", "KREEP", "KREWE", "KRILL", "KRONA", "KRONE", "KROON", "KRUBI", "KUDOS", "KUDUS", "KUDZU", "KUFIS", "KUGEL", "KUKRI",
        "KULAK", "KUMYS", "KURTA", "KURUS", "KUSSO", "KVASS", "KVELL", "KYACK", "KYAKS", "KYARS", "KYATS", "KYLIX", "KYRIE", "KYTES", "KYTHE"
    };
    public static List<string> FiveLetter_L = new List<string>()
    {
        "LAARI", "LABEL", "LABIA", "LABOR", "LABRA", "LACED", "LACER", "LACES", "LACEY", "LACKS", "LADED", "LADEN", "LADER", "LADES", "LADLE", "LAEVO", "LAGAN",
        "LAGER", "LAHAR", "LAICH", "LAICS", "LAIGH", "LAIRD", "LAIRS", "LAITH", "LAITY", "LAKED", "LAKER", "LAKES", "LAKHS", "LALLS", "LAMAS", "LAMBS", "LAMBY",
        "LAMED", "LAMER", "LAMES", "LAMIA", "LAMPS", "LANAI", "LANCE", "LANDS", "LANES", "LANKY", "LAPEL", "LAPIN", "LAPIS", "LAPSE", "LARCH", "LARDS", "LARDY",
        "LAREE", "LARES", "LARGE", "LARGO", "LARIS", "LARKS", "LARKY", "LARUM", "LARVA", "LASED", "LASER", "LASES", "LASSI", "LASSO", "LASTS", "LATCH", "LATED",
        "LATEN", "LATER", "LATEX", "LATHE", "LATHI", "LATHS", "LATHY", "LATKE", "LATTE", "LAUAN", "LAUDS", "LAUGH", "LAURA", "LAVAS", "LAVED", "LAVER", "LAVES",
        "LAWED", "LAWNS", "LAWNY", "LAXER", "LAXES", "LAXLY", "LAYED", "LAYER", "LAYIN", "LAYUP", "LAZAR", "LAZED", "LAZES", "LEACH", "LEADS", "LEADY", "LEAFS",
        "LEAFY", "LEAKS", "LEAKY", "LEANS", "LEANT", "LEAPS", "LEAPT", "LEARN", "LEARS", "LEARY", "LEASE", "LEASH", "LEAST", "LEAVE", "LEAVY", "LEBEN", "LEDGE",
        "LEDGY", "LEECH", "LEEKS", "LEERS", "LEERY", "LEETS", "LEFTS", "LEFTY", "LEGAL", "LEGER", "LEGES", "LEGGY", "LEGIT", "LEHRS", "LEHUA", "LEMAN", "LEMMA",
        "LEMON", "LEMUR", "LENDS", "LENES", "LENIS", "LENOS", "LENSE", "LENTO", "LEONE", "LEPER", "LEPTA", "LESES", "LETCH", "LETHE", "LETUP", "LEUDS", "LEVEE",
        "LEVEL", "LEVER", "LEVIN", "LEVIS", "LEWIS", "LEXES", "LEXIS", "LEZZY", "LIANA", "LIANE", "LIANG", "LIARD", "LIARS", "LIBEL", "LIBER", "LIBRA", "LIBRI",
        "LICHI", "LICHT", "LICIT", "LICKS", "LIDAR", "LIDOS", "LIEGE", "LIENS", "LIERS", "LIEUS", "LIEVE", "LIFER", "LIFTS", "LIGAN", "LIGER", "LIGHT", "LIKED",
        "LIKEN", "LIKER", "LIKES", "LILAC", "LILOS", "LILTS", "LIMAN", "LIMAS", "LIMBA", "LIMBI", "LIMBO", "LIMBS", "LIMBY", "LIMED", "LIMEN", "LIMES", "LIMEY",
        "LIMIT", "LIMNS", "LIMOS", "LIMPA", "LIMPS", "LINAC", "LINDY", "LINED", "LINEN", "LINER", "LINES", "LINEY", "LINGA", "LINGO", "LINGS", "LINGY", "LININ",
        "LINKS", "LINKY", "LINNS", "LINOS", "LINTS", "LINTY", "LINUM", "LIONS", "LIPID", "LIPIN", "LIPPY", "LIRAS", "LIROT", "LISLE", "LISPS", "LISTS", "LITAI",
        "LITAS", "LITER", "LITHE", "LITHO", "LITRE", "LIVED", "LIVEN", "LIVER", "LIVES", "LIVID", "LIVRE", "LLAMA", "LLANO", "LOACH", "LOADS", "LOAFS", "LOAMS",
        "LOAMY", "LOANS", "LOATH", "LOBAR", "LOBBY", "LOBED", "LOBES", "LOBOS", "LOCAL", "LOCHS", "LOCKS", "LOCOS", "LOCUM", "LOCUS", "LODEN", "LODES", "LODGE",
        "LOESS", "LOFTS", "LOFTY", "LOGAN", "LOGES", "LOGGY", "LOGIA", "LOGIC", "LOGIN", "LOGOI", "LOGON", "LOGOS", "LOIDS", "LOINS", "LOLLS", "LOLLY", "LONER",
        "LONGE", "LONGS", "LOOBY", "LOOED", "LOOEY", "LOOFA", "LOOFS", "LOOIE", "LOOKS", "LOOMS", "LOONS", "LOONY", "LOOPS", "LOOPY", "LOOSE", "LOOTS", "LOPED",
        "LOPER", "LOPES", "LOPPY", "LORAL", "LORAN", "LORDS", "LORES", "LORIS", "LORRY", "LOSEL", "LOSER", "LOSES", "LOSSY", "LOTAH", "LOTAS", "LOTIC", "LOTOS",
        "LOTTE", "LOTTO", "LOTUS", "LOUGH", "LOUIE", "LOUIS", "LOUMA", "LOUPE", "LOUPS", "LOURS", "LOURY", "LOUSE", "LOUSY", "LOUTS", "LOVAT", "LOVED", "LOVER",
        "LOVES", "LOWED", "LOWER", "LOWES", "LOWLY", "LOWSE", "LOXED", "LOXES", "LOYAL", "LUAUS", "LUBED", "LUBES", "LUCES", "LUCID", "LUCKS", "LUCKY", "LUCRE",
        "LUDES", "LUDIC", "LUFFA", "LUFFS", "LUGED", "LUGER", "LUGES", "LULLS", "LULUS", "LUMAS", "LUMEN", "LUMPS", "LUMPY", "LUNAR", "LUNAS", "LUNCH", "LUNES",
        "LUNET", "LUNGE", "LUNGI", "LUNGS", "LUNKS", "LUNTS", "LUPIN", "LUPUS", "LURCH", "LURED", "LURER", "LURES", "LUREX", "LURID", "LURKS", "LUSTS", "LUSTY",
        "LUSUS", "LUTEA", "LUTED", "LUTES", "LUXES", "LWEIS", "LYARD", "LYART", "LYASE", "LYCEA", "LYCEE", "LYCRA", "LYING", "LYMPH", "LYNCH", "LYRES", "LYRIC",
        "LYSED", "LYSES", "LYSIN", "LYSIS", "LYSSA", "LYTIC", "LYTTA"
    };
    public static List<string> FiveLetter_M = new List<string>()
    {
        "MAARS", "MABES", "MACAW", "MACED", "MACER", "MACES", "MACHE", "MACHO", "MACHS", "MACKS", "MACLE", "MACON", "MACRO", "MADAM", "MADLY", "MADRE", "MAFIA",
        "MAFIC", "MAGES", "MAGIC", "MAGMA", "MAGOT", "MAGUS", "MAHOE", "MAIDS", "MAILE", "MAILL", "MAILS", "MAIMS", "MAINS", "MAIRS", "MAIST", "MAIZE", "MAJOR",
        "MAKAR", "MAKER", "MAKES", "MAKOS", "MALAR", "MALES", "MALIC", "MALLS", "MALMS", "MALMY", "MALTS", "MALTY", "MAMAS", "MAMBA", "MAMBO", "MAMEY", "MAMIE",
        "MAMMA", "MAMMY", "MANAS", "MANAT", "MANED", "MANES", "MANGA", "MANGE", "MANGO", "MANGY", "MANIA", "MANIC", "MANLY", "MANNA", "MANOR", "MANOS", "MANSE",
        "MANTA", "MANUS", "MAPLE", "MAQUI", "MARAS", "MARCH", "MARCS", "MARES", "MARGE", "MARIA", "MARKA", "MARKS", "MARLS", "MARLY", "MARRY", "MARSE", "MARSH",
        "MARTS", "MARVY", "MASAS", "MASER", "MASHY", "MASKS", "MASON", "MASSA", "MASSE", "MASSY", "MASTS", "MATCH", "MATED", "MATER", "MATES", "MATEY", "MATHS",
        "MATIN", "MATTE", "MATTS", "MATZA", "MATZO", "MAUDS", "MAULS", "MAUND", "MAUTS", "MAUVE", "MAVEN", "MAVIE", "MAVIN", "MAVIS", "MAWED", "MAXED", "MAXES",
        "MAXIM", "MAXIS", "MAYAN", "MAYAS", "MAYBE", "MAYED", "MAYOR", "MAYOS", "MAYST", "MAZED", "MAZER", "MAZES", "MBIRA", "MEADS", "MEALS", "MEALY", "MEANS",
        "MEANT", "MEANY", "MEATS", "MEATY", "MECCA", "MEDAL", "MEDIA", "MEDIC", "MEDII", "MEEDS", "MEETS", "MEINY", "MELDS", "MELEE", "MELIC", "MELLS", "MELON",
        "MELTS", "MELTY", "MEMES", "MEMOS", "MENAD", "MENDS", "MENSA", "MENSE", "MENSH", "MENTA", "MENUS", "MEOUS", "MEOWS", "MERCH", "MERCS", "MERCY", "MERDE",
        "MERER", "MERES", "MERGE", "MERIT", "MERKS", "MERLE", "MERLS", "MERRY", "MESAS", "MESHY", "MESIC", "MESNE", "MESON", "MESSY", "METAL", "METED", "METER",
        "METES", "METHS", "METIS", "METOL", "METRE", "METRO", "MEWED", "MEWLS", "MEZES", "MEZZO", "MIAOU", "MIAOW", "MIASM", "MIAUL", "MICAS", "MICHE", "MICRA",
        "MICRO", "MIDDY", "MIDGE", "MIDIS", "MIDST", "MIENS", "MIFFS", "MIFFY", "MIGGS", "MIGHT", "MIKED", "MIKES", "MIKRA", "MILCH", "MILDS", "MILER", "MILES",
        "MILIA", "MILKS", "MILKY", "MILLE", "MILLS", "MILOS", "MILPA", "MILTS", "MILTY", "MIMED", "MIMEO", "MIMER", "MIMES", "MIMIC", "MINAE", "MINAS", "MINCE",
        "MINCY", "MINDS", "MINED", "MINER", "MINES", "MINGY", "MINIM", "MINIS", "MINKE", "MINKS", "MINNY", "MINOR", "MINTS", "MINTY", "MINUS", "MIRED", "MIRES",
        "MIREX", "MIRIN", "MIRKS", "MIRKY", "MIRTH", "MIRZA", "MISDO", "MISER", "MISES", "MISOS", "MISSY", "MISTS", "MISTY", "MITER", "MITES", "MITIS", "MITRE",
        "MITTS", "MIXED", "MIXER", "MIXES", "MIXUP", "MIZEN", "MOANS", "MOATS", "MOCHA", "MOCKS", "MODAL", "MODEL", "MODEM", "MODES", "MODUS", "MOGGY", "MOGUL",
        "MOHEL", "MOHUR", "MOILS", "MOIRA", "MOIRE", "MOIST", "MOJOS", "MOKES", "MOLAL", "MOLAR", "MOLAS", "MOLDS", "MOLDY", "MOLES", "MOLLS", "MOLLY", "MOLTO",
        "MOLTS", "MOMES", "MOMMA", "MOMMY", "MOMUS", "MONAD", "MONAS", "MONDE", "MONDO", "MONEY", "MONGO", "MONIE", "MONKS", "MONOS", "MONTE", "MONTH", "MOOCH",
        "MOODS", "MOODY", "MOOED", "MOOLA", "MOOLS", "MOONS", "MOONY", "MOORS", "MOORY", "MOOSE", "MOOTS", "MOPED", "MOPER", "MOPES", "MOPEY", "MORAE", "MORAL",
        "MORAS", "MORAY", "MOREL", "MORES", "MORNS", "MORON", "MORPH", "MORRO", "MORSE", "MORTS", "MOSEY", "MOSKS", "MOSSO", "MOSSY", "MOSTE", "MOSTS", "MOTEL",
        "MOTES", "MOTET", "MOTEY", "MOTHS", "MOTHY", "MOTIF", "MOTOR", "MOTTE", "MOTTO", "MOTTS", "MOUCH", "MOUES", "MOULD", "MOULT", "MOUND", "MOUNT", "MOURN",
        "MOUSE", "MOUSY", "MOUTH", "MOVED", "MOVER", "MOVES", "MOVIE", "MOWED", "MOWER", "MOXAS", "MOXIE", "MOZOS", "MUCHO", "MUCID", "MUCIN", "MUCKS", "MUCKY",
        "MUCOR", "MUCRO", "MUCUS", "MUDDY", "MUDRA", "MUFFS", "MUFTI", "MUGGS", "MUGGY", "MUHLY", "MUJIK", "MULCH", "MULCT", "MULED", "MULES", "MULEY", "MULLA",
        "MULLS", "MUMMS", "MUMMY", "MUMPS", "MUMUS", "MUNCH", "MUNGO", "MUNIS", "MUONS", "MURAL", "MURAS", "MURED", "MURES", "MUREX", "MURID", "MURKS", "MURKY",
        "MURRA", "MURRE", "MURRS", "MURRY", "MUSCA", "MUSED", "MUSER", "MUSES", "MUSHY", "MUSIC", "MUSKS", "MUSKY", "MUSSY", "MUSTH", "MUSTS", "MUSTY", "MUTCH",
        "MUTED", "MUTER", "MUTES", "MUTON", "MUTTS", "MUZZY", "MYLAR", "MYNAH", "MYNAS", "MYOID", "MYOMA", "MYOPE", "MYOPY", "MYRRH", "MYSID", "MYTHS", "MYTHY"
    };
    public static List<string> FiveLetter_N = new List<string>()
    {
        "NAANS", "NABES", "NABIS", "NABOB", "NACHO", "NACRE", "NADAS", "NADIR", "NAEVI", "NAFFS", "NAGGY", "NAIAD", "NAIFS", "NAILS", "NAIRA", "NAIRU", "NAIVE",
        "NAKED", "NAKFA", "NALAS", "NALED", "NAMED", "NAMER", "NAMES", "NANAS", "NANCE", "NANCY", "NANNY", "NAPAS", "NAPES", "NAPPA", "NAPPE", "NAPPY", "NARCO",
        "NARCS", "NARDS", "NARES", "NARIC", "NARIS", "NARKS", "NARKY", "NASAL", "NASTY", "NATAL", "NATCH", "NATES", "NATTY", "NAVAL", "NAVAR", "NAVEL", "NAVES",
        "NAVVY", "NAWAB", "NAZIS", "NEAPS", "NEARS", "NEATH", "NEATS", "NECKS", "NEDDY", "NEEDS", "NEEDY", "NEEMS", "NEEPS", "NEGUS", "NEIFS", "NEIGH", "NEIST",
        "NELLY", "NEMAS", "NENES", "NEONS", "NERDS", "NERDY", "NEROL", "NERTS", "NERTZ", "NERVE", "NERVY", "NESTS", "NETOP", "NETTS", "NETTY", "NEUKS", "NEUME",
        "NEUMS", "NEVER", "NEVES", "NEVUS", "NEWEL", "NEWER", "NEWIE", "NEWLY", "NEWSY", "NEWTS", "NEXUS", "NGWEE", "NICAD", "NICER", "NICHE", "NICKS", "NICOL",
        "NIDAL", "NIDED", "NIDES", "NIDUS", "NIECE", "NIEVE", "NIFTY", "NIGHS", "NIGHT", "NIHIL", "NILLS", "NIMBI", "NINES", "NINJA", "NINNY", "NINON", "NINTH",
        "NIPAS", "NIPPY", "NISEI", "NISUS", "NITER", "NITES", "NITID", "NITON", "NITRE", "NITRO", "NITTY", "NIVAL", "NIXED", "NIXES", "NIXIE", "NIZAM", "NOBBY",
        "NOBLE", "NOBLY", "NOCKS", "NODAL", "NODDY", "NODES", "NODUS", "NOELS", "NOGGS", "NOHOW", "NOILS", "NOILY", "NOIRS", "NOISE", "NOISY", "NOLOS", "NOMAD",
        "NOMAS", "NOMEN", "NOMES", "NOMOI", "NOMOS", "NONAS", "NONCE", "NONES", "NONET", "NONYL", "NOOKS", "NOOKY", "NOONS", "NOOSE", "NOPAL", "NORIA", "NORIS",
        "NORMS", "NORTH", "NOSED", "NOSES", "NOSEY", "NOTAL", "NOTCH", "NOTED", "NOTER", "NOTES", "NOTUM", "NOUNS", "NOVAE", "NOVAS", "NOVEL", "NOWAY", "NOWTS",
        "NUBBY", "NUBIA", "NUCHA", "NUDER", "NUDES", "NUDGE", "NUDIE", "NUDZH", "NUKED", "NUKES", "NULLS", "NUMBS", "NUMEN", "NURDS", "NURLS", "NURSE", "NUTSY",
        "NUTTY", "NYALA", "NYLON", "NYMPH"
    };
    public static List<string> FiveLetter_O = new List<string>()
    {
        "OAKEN", "OAKUM", "OARED", "OASES", "OASIS", "OASTS", "OATEN", "OATER", "OATHS", "OAVES", "OBEAH", "OBELI", "OBESE", "OBEYS", "OBIAS", "OBITS", "OBJET",
        "OBOES", "OBOLE", "OBOLI", "OBOLS", "OCCUR", "OCEAN", "OCHER", "OCHRE", "OCHRY", "OCKER", "OCREA", "OCTAD", "OCTAL", "OCTAN", "OCTET", "OCTYL", "OCULI",
        "ODAHS", "ODDER", "ODDLY", "ODEON", "ODEUM", "ODIST", "ODIUM", "ODORS", "ODOUR", "ODYLE", "ODYLS", "OFAYS", "OFFAL", "OFFED", "OFFER", "OFTEN", "OFTER",
        "OGAMS", "OGEES", "OGHAM", "OGIVE", "OGLED", "OGLER", "OGLES", "OGRES", "OHIAS", "OHING", "OHMIC", "OIDIA", "OILED", "OILER", "OINKS", "OKAPI", "OKAYS",
        "OKEHS", "OKRAS", "OLDEN", "OLDER", "OLDIE", "OLEIC", "OLEIN", "OLEOS", "OLEUM", "OLIOS", "OLIVE", "OLLAS", "OLOGY", "OMASA", "OMBER", "OMBRE", "OMEGA",
        "OMENS", "OMERS", "OMITS", "ONCET", "ONERY", "ONION", "ONIUM", "ONLAY", "ONSET", "ONTIC", "OOHED", "OOMPH", "OORIE", "OOTID", "OOZED", "OOZES", "OPAHS",
        "OPALS", "OPENS", "OPERA", "OPINE", "OPING", "OPIUM", "OPSIN", "OPTED", "OPTIC", "ORACH", "ORALS", "ORANG", "ORATE", "ORBED", "ORBIT", "ORCAS", "ORCIN",
        "ORDER", "ORDOS", "OREAD", "ORGAN", "ORGIC", "ORIBI", "ORIEL", "ORLES", "ORLON", "ORLOP", "ORMER", "ORNIS", "ORPIN", "ORRIS", "ORTHO", "ORZOS", "OSIER",
        "OSMIC", "OSMOL", "OSSIA", "OSTIA", "OTHER", "OTTAR", "OTTER", "OTTOS", "OUGHT", "OUNCE", "OUPHE", "OUPHS", "OURIE", "OUSEL", "OUSTS", "OUTBY", "OUTDO",
        "OUTED", "OUTER", "OUTGO", "OUTRE", "OUZEL", "OUZOS", "OVALS", "OVARY", "OVATE", "OVENS", "OVERS", "OVERT", "OVINE", "OVOID", "OVOLI", "OVOLO", "OVULE",
        "OWING", "OWLET", "OWNED", "OWNER", "OWSEN", "OXBOW", "OXEYE", "OXIDE", "OXIDS", "OXIME", "OXIMS", "OXLIP", "OXTER", "OYERS", "OZONE"
    };
    public static List<string> FiveLetter_P = new List<string>()
    {
        "PACAS", "PACED", "PACER", "PACES", "PACEY", "PACHA", "PACKS", "PACTS", "PADDY", "PADIS", "PADLE", "PADRE", "PADRI", "PAEAN", "PAEON", "PAGAN", "PAGED",
        "PAGER", "PAGES", "PAGOD", "PAIKS", "PAILS", "PAINS", "PAINT", "PAIRS", "PAISA", "PAISE", "PALEA", "PALED", "PALER", "PALES", "PALET", "PALLS", "PALLY",
        "PALMS", "PALMY", "PALPI", "PALPS", "PALSY", "PAMPA", "PANDA", "PANDY", "PANED", "PANEL", "PANES", "PANGA", "PANGS", "PANIC", "PANNE", "PANSY", "PANTO",
        "PANTS", "PANTY", "PAPAL", "PAPAS", "PAPAW", "PAPER", "PAPPI", "PAPPY", "PARAE", "PARAS", "PARCH", "PARDI", "PARDS", "PARDY", "PARED", "PAREO", "PARER",
        "PARES", "PAREU", "PARGE", "PARGO", "PARIS", "PARKA", "PARKS", "PARLE", "PAROL", "PARRS", "PARRY", "PARSE", "PARTS", "PARTY", "PARVE", "PARVO", "PASEO",
        "PASES", "PASHA", "PASSE", "PASTA", "PASTE", "PASTS", "PASTY", "PATCH", "PATED", "PATEN", "PATER", "PATES", "PATHS", "PATIN", "PATIO", "PATLY", "PATSY",
        "PATTY", "PAUSE", "PAVAN", "PAVED", "PAVER", "PAVES", "PAVID", "PAVIN", "PAVIS", "PAWED", "PAWER", "PAWKY", "PAWLS", "PAWNS", "PAXES", "PAYED", "PAYEE",
        "PAYER", "PAYOR", "PEACE", "PEACH", "PEAGE", "PEAGS", "PEAKS", "PEAKY", "PEALS", "PEANS", "PEARL", "PEARS", "PEART", "PEASE", "PEATS", "PEATY", "PEAVY",
        "PECAN", "PECHS", "PECKS", "PECKY", "PEDAL", "PEDES", "PEDRO", "PEEKS", "PEELS", "PEENS", "PEEPS", "PEERS", "PEERY", "PEEVE", "PEINS", "PEISE", "PEKAN",
        "PEKES", "PEKIN", "PEKOE", "PELES", "PELFS", "PELON", "PELTS", "PENAL", "PENCE", "PENDS", "PENES", "PENGO", "PENNA", "PENNE", "PENNI", "PENNY", "PEONS",
        "PEONY", "PEPLA", "PEPOS", "PEPPY", "PERCH", "PERDU", "PERDY", "PEREA", "PERES", "PERIL", "PERIS", "PERKS", "PERKY", "PERMS", "PERPS", "PERRY", "PERSE",
        "PERVS", "PESKY", "PESOS", "PESTO", "PESTS", "PESTY", "PETAL", "PETER", "PETIT", "PETTI", "PETTO", "PETTY", "PEWEE", "PEWIT", "PHAGE", "PHASE", "PHIAL",
        "PHLOX", "PHONE", "PHONO", "PHONS", "PHONY", "PHOTO", "PHOTS", "PHPHT", "PHUTS", "PHYLA", "PHYLE", "PIANO", "PIANS", "PIBAL", "PICAL", "PICAS", "PICKS",
        "PICKY", "PICOT", "PICUL", "PIECE", "PIERS", "PIETA", "PIETY", "PIGGY", "PIGMY", "PIING", "PIKAS", "PIKED", "PIKER", "PIKES", "PIKIS", "PILAF", "PILAR",
        "PILAU", "PILAW", "PILEA", "PILED", "PILEI", "PILES", "PILIS", "PILLS", "PILOT", "PILUS", "PIMAS", "PIMPS", "PINAS", "PINCH", "PINED", "PINES", "PINEY",
        "PINGO", "PINGS", "PINKO", "PINKS", "PINKY", "PINNA", "PINNY", "PINON", "PINOT", "PINTA", "PINTO", "PINTS", "PINUP", "PIONS", "PIOUS", "PIPAL", "PIPED",
        "PIPER", "PIPES", "PIPET", "PIPIT", "PIQUE", "PIRNS", "PIROG", "PISCO", "PISOS", "PISTE", "PITAS", "PITCH", "PITHS", "PITHY", "PITON", "PITTA", "PIVOT",
        "PIXEL", "PIXES", "PIXIE", "PIZZA", "PLACE", "PLACK", "PLAGE", "PLAID", "PLAIN", "PLAIT", "PLANE", "PLANK", "PLANS", "PLANT", "PLASH", "PLASM", "PLATE",
        "PLATS", "PLATY", "PLAYA", "PLAYS", "PLAZA", "PLEAD", "PLEAS", "PLEAT", "PLEBE", "PLEBS", "PLENA", "PLEON", "PLEWS", "PLICA", "PLIED", "PLIER", "PLIES",
        "PLINK", "PLODS", "PLONK", "PLOPS", "PLOTS", "PLOTZ", "PLOWS", "PLOYS", "PLUCK", "PLUGS", "PLUMB", "PLUME", "PLUMP", "PLUMS", "PLUMY", "PLUNK", "PLUSH",
        "PLYER", "POACH", "POBOY", "POCKS", "POCKY", "PODGY", "PODIA", "POEMS", "POESY", "POETS", "POGEY", "POILU", "POIND", "POINT", "POISE", "POKED", "POKER",
        "POKES", "POKEY", "POLAR", "POLED", "POLER", "POLES", "POLIO", "POLIS", "POLKA", "POLLS", "POLOS", "POLYP", "POLYS", "POMES", "POMMY", "POMOS", "POMPS",
        "PONCE", "PONDS", "PONES", "PONGS", "POOCH", "POODS", "POOED", "POOFS", "POOFY", "POOHS", "POOLS", "POONS", "POOPS", "POORI", "POOVE", "POPES", "POPPA",
        "POPPY", "POPSY", "PORCH", "PORED", "PORES", "PORGY", "PORKS", "PORKY", "PORNS", "PORNY", "PORTS", "POSED", "POSER", "POSES", "POSIT", "POSSE", "POSTS",
        "POTSY", "POTTO", "POTTY", "POUCH", "POUFF", "POUFS", "POULT", "POUND", "POURS", "POUTS", "POUTY", "POWER", "POXED", "POXES", "POYOU", "PRAAM", "PRAHU",
        "PRAMS", "PRANG", "PRANK", "PRAOS", "PRASE", "PRATE", "PRATS", "PRAUS", "PRAWN", "PRAYS", "PREED", "PREEN", "PREES", "PREOP", "PREPS", "PRESA", "PRESE",
        "PRESS", "PREST", "PREXY", "PREYS", "PRICE", "PRICY", "PRIDE", "PRIED", "PRIER", "PRIES", "PRIGS", "PRILL", "PRIMA", "PRIME", "PRIMI", "PRIMO", "PRIMP",
        "PRIMS", "PRINK", "PRINT", "PRION", "PRIOR", "PRISE", "PRISM", "PRISS", "PRIVY", "PRIZE", "PROAS", "PROBE", "PRODS", "PROEM", "PROFS", "PROGS", "PROLE",
        "PROMO", "PROMS", "PRONE", "PRONG", "PROOF", "PROPS", "PROSE", "PROSO", "PROSS", "PROST", "PROSY", "PROUD", "PROVE", "PROWL", "PROWS", "PROXY", "PRUDE",
        "PRUNE", "PRUTA", "PRYER", "PSALM", "PSEUD", "PSHAW", "PSOAE", "PSOAI", "PSOAS", "PSYCH", "PUBES", "PUBIC", "PUBIS", "PUCES", "PUCKA", "PUCKS", "PUDGY",
        "PUDIC", "PUFFS", "PUFFY", "PUGGY", "PUJAH", "PUJAS", "PUKED", "PUKES", "PUKKA", "PULED", "PULER", "PULES", "PULIK", "PULIS", "PULLS", "PULPS", "PULPY",
        "PULSE", "PUMAS", "PUMPS", "PUNAS", "PUNCH", "PUNGS", "PUNJI", "PUNKA", "PUNKS", "PUNKY", "PUNNY", "PUNTO", "PUNTS", "PUNTY", "PUPAE", "PUPAL", "PUPAS",
        "PUPIL", "PUPPY", "PUPUS", "PURDA", "PUREE", "PURER", "PURGE", "PURIN", "PURIS", "PURLS", "PURRS", "PURSE", "PURSY", "PURTY", "PUSES", "PUSHY", "PUTON",
        "PUTTI", "PUTTO", "PUTTS", "PUTTY", "PYGMY", "PYINS", "PYLON", "PYOID", "PYRAN", "PYRES", "PYREX", "PYRIC", "PYROS", "PYXES", "PYXIE", "PYXIS"
    };
    public static List<string> FiveLetter_Q = new List<string>()
    {
        "QADIS", "QAIDS", "QANAT", "QOPHS", "QUACK", "QUADS", "QUAFF", "QUAGS", "QUAIL", "QUAIS", "QUAKE", "QUAKY", "QUALE", "QUALM", "QUANT", "QUARE", "QUARK",
        "QUART", "QUASH", "QUASI", "QUASS", "QUATE", "QUAYS", "QUBIT", "QUEAN", "QUEEN", "QUELL", "QUERN", "QUERY", "QUEST", "QUEUE", "QUEYS", "QUICK", "QUIDS",
        "QUIET", "QUIFF", "QUILL", "QUILT", "QUINS", "QUINT", "QUIPS", "QUIPU", "QUIRE", "QUIRK", "QUIRT", "QUITE", "QUITS", "QUODS", "QUOIN", "QUOIT", "QUOLL",
        "QUOTA", "QUOTE", "QUOTH", "QURSH"
    };
    public static List<string> FiveLetter_R = new List<string>()
    {
        "RABAT", "RABBI", "RABIC", "RABID", "RACED", "RACER", "RACES", "RACKS", "RACON", "RADAR", "RADII", "RADIO", "RADIX", "RADON", "RAFFS", "RAFTS", "RAGAS",
        "RAGED", "RAGEE", "RAGES", "RAGGS", "RAGGY", "RAGIS", "RAIAS", "RAIDS", "RAILS", "RAINS", "RAINY", "RAISE", "RAITA", "RAJAH", "RAJAS", "RAJES", "RAKED",
        "RAKEE", "RAKER", "RAKES", "RAKIS", "RAKUS", "RALES", "RALLY", "RALPH", "RAMAL", "RAMEE", "RAMEN", "RAMET", "RAMIE", "RAMMY", "RAMPS", "RAMUS", "RANCE",
        "RANCH", "RANDS", "RANDY", "RANEE", "RANGE", "RANGY", "RANID", "RANIS", "RANKS", "RANTS", "RAPED", "RAPER", "RAPES", "RAPHE", "RAPID", "RARED", "RARER",
        "RARES", "RASED", "RASER", "RASES", "RASPS", "RASPY", "RATAL", "RATAN", "RATCH", "RATED", "RATEL", "RATER", "RATES", "RATHE", "RATIO", "RATOS", "RATTY",
        "RAVED", "RAVEL", "RAVEN", "RAVER", "RAVES", "RAVIN", "RAWER", "RAWIN", "RAWLY", "RAXED", "RAXES", "RAYAH", "RAYAS", "RAYED", "RAYON", "RAZED", "RAZEE",
        "RAZER", "RAZES", "RAZOR", "REACH", "REACT", "READD", "READS", "READY", "REALM", "REALS", "REAMS", "REAPS", "REARM", "REARS", "REATA", "REAVE", "REBAR",
        "REBBE", "REBEC", "REBEL", "REBID", "REBOP", "REBUS", "REBUT", "REBUY", "RECAP", "RECCE", "RECIT", "RECKS", "RECON", "RECTA", "RECTI", "RECTO", "RECUR",
        "RECUT", "REDAN", "REDDS", "REDED", "REDES", "REDIA", "REDID", "REDIP", "REDLY", "REDON", "REDOS", "REDOX", "REDRY", "REDUB", "REDUX", "REDYE", "REEDS",
        "REEDY", "REEFS", "REEFY", "REEKS", "REEKY", "REELS", "REEST", "REEVE", "REFED", "REFEL", "REFER", "REFIT", "REFIX", "REFLY", "REFRY", "REGAL", "REGES",
        "REGMA", "REGNA", "REHAB", "REHEM", "REIFS", "REIFY", "REIGN", "REINK", "REINS", "REIVE", "REJIG", "REKEY", "RELAX", "RELAY", "RELET", "RELIC", "RELIT",
        "REMAN", "REMAP", "REMET", "REMEX", "REMIT", "REMIX", "RENAL", "RENDS", "RENEW", "RENIG", "RENIN", "RENTE", "RENTS", "REOIL", "REPAY", "REPEG", "REPEL",
        "REPIN", "REPLY", "REPOS", "REPOT", "REPPS", "REPRO", "RERAN", "RERIG", "RERUN", "RESAT", "RESAW", "RESAY", "RESEE", "RESET", "RESEW", "RESID", "RESIN",
        "RESIT", "RESOD", "RESOW", "RESTS", "RETAG", "RETAX", "RETCH", "RETEM", "RETIA", "RETIE", "RETRO", "RETRY", "REUSE", "REVEL", "REVET", "REVUE", "REWAN",
        "REWAX", "REWED", "REWET", "REWIN", "REWON", "REXES", "RHEAS", "RHEME", "RHEUM", "RHINO", "RHOMB", "RHUMB", "RHYME", "RHYTA", "RIALS", "RIANT", "RIATA",
        "RIBBY", "RIBES", "RICED", "RICER", "RICES", "RICIN", "RICKS", "RIDER", "RIDES", "RIDGE", "RIDGY", "RIELS", "RIFER", "RIFFS", "RIFLE", "RIFTS", "RIGHT",
        "RIGID", "RIGOR", "RILED", "RILES", "RILEY", "RILLE", "RILLS", "RIMED", "RIMER", "RIMES", "RINDS", "RINDY", "RINGS", "RINKS", "RINSE", "RIOJA", "RIOTS",
        "RIPED", "RIPEN", "RIPER", "RIPES", "RISEN", "RISER", "RISES", "RISHI", "RISKS", "RISKY", "RISUS", "RITES", "RITZY", "RIVAL", "RIVED", "RIVEN", "RIVER",
        "RIVES", "RIVET", "RIYAL", "ROACH", "ROADS", "ROAMS", "ROANS", "ROARS", "ROAST", "ROBED", "ROBES", "ROBIN", "ROBLE", "ROBOT", "ROCKS", "ROCKY", "RODEO",
        "RODES", "ROGER", "ROGUE", "ROILS", "ROILY", "ROLES", "ROLFS", "ROLLS", "ROMAN", "ROMEO", "ROMPS", "RONDO", "ROODS", "ROOFS", "ROOKS", "ROOKY", "ROOMS",
        "ROOMY", "ROOSE", "ROOST", "ROOTS", "ROOTY", "ROPED", "ROPER", "ROPES", "ROPEY", "ROQUE", "ROSED", "ROSES", "ROSET", "ROSHI", "ROSIN", "ROTAS", "ROTCH",
        "ROTES", "ROTIS", "ROTLS", "ROTOR", "ROTOS", "ROTTE", "ROUEN", "ROUES", "ROUGE", "ROUGH", "ROUND", "ROUPS", "ROUPY", "ROUSE", "ROUST", "ROUTE", "ROUTH",
        "ROUTS", "ROVED", "ROVEN", "ROVER", "ROVES", "ROWAN", "ROWDY", "ROWED", "ROWEL", "ROWEN", "ROWER", "ROWTH", "ROYAL", "RUANA", "RUBBY", "RUBEL", "RUBES",
        "RUBLE", "RUBUS", "RUCHE", "RUCKS", "RUDDS", "RUDDY", "RUDER", "RUERS", "RUFFE", "RUFFS", "RUGAE", "RUGAL", "RUGBY", "RUING", "RUINS", "RULED", "RULER",
        "RULES", "RUMBA", "RUMEN", "RUMMY", "RUMOR", "RUMPS", "RUNES", "RUNGS", "RUNIC", "RUNNY", "RUNTS", "RUNTY", "RUPEE", "RURAL", "RUSES", "RUSHY", "RUSKS",
        "RUSTS", "RUSTY", "RUTHS", "RUTIN", "RUTTY", "RYKED", "RYKES", "RYNDS", "RYOTS"
    };
    public static List<string> FiveLetter_S = new List<string>()
    {
        "SABAL", "SABED", "SABER", "SABES", "SABIN", "SABIR", "SABLE", "SABOT", "SABRA", "SABRE", "SACKS", "SACRA", "SADES", "SADHE", "SADHU", "SADIS", "SADLY",
        "SAFER", "SAFES", "SAGAS", "SAGER", "SAGES", "SAGGY", "SAGOS", "SAGUM", "SAHIB", "SAICE", "SAIDS", "SAIGA", "SAILS", "SAINS", "SAINT", "SAITH", "SAJOU",
        "SAKER", "SAKES", "SAKIS", "SALAD", "SALAL", "SALEP", "SALES", "SALIC", "SALLY", "SALMI", "SALOL", "SALON", "SALPA", "SALPS", "SALSA", "SALTS", "SALTY",
        "SALVE", "SALVO", "SAMBA", "SAMBO", "SAMEK", "SAMPS", "SANDS", "SANDY", "SANED", "SANER", "SANES", "SANGA", "SANGH", "SANTO", "SAPID", "SAPOR", "SAPPY",
        "SARAN", "SARDS", "SAREE", "SARGE", "SARGO", "SARIN", "SARIS", "SARKS", "SARKY", "SAROD", "SAROS", "SASIN", "SASSY", "SATAY", "SATED", "SATEM", "SATES",
        "SATIN", "SATIS", "SATYR", "SAUCE", "SAUCH", "SAUCY", "SAUGH", "SAULS", "SAULT", "SAUNA", "SAURY", "SAUTE", "SAVED", "SAVER", "SAVES", "SAVIN", "SAVOR",
        "SAVOY", "SAVVY", "SAWED", "SAWER", "SAXES", "SAYED", "SAYER", "SAYID", "SAYST", "SCABS", "SCADS", "SCAGS", "SCALD", "SCALE", "SCALL", "SCALP", "SCALY",
        "SCAMP", "SCAMS", "SCANS", "SCANT", "SCAPE", "SCARE", "SCARF", "SCARP", "SCARS", "SCART", "SCARY", "SCATS", "SCATT", "SCAUP", "SCAUR", "SCENA", "SCEND",
        "SCENE", "SCENT", "SCHAV", "SCHMO", "SCHUL", "SCHWA", "SCION", "SCOFF", "SCOLD", "SCONE", "SCOOP", "SCOOT", "SCOPE", "SCOPS", "SCORE", "SCORN", "SCOTS",
        "SCOUR", "SCOUT", "SCOWL", "SCOWS", "SCRAG", "SCRAM", "SCRAP", "SCREE", "SCRIM", "SCRIP", "SCROD", "SCRUB", "SCRUM", "SCUBA", "SCUDI", "SCUDO", "SCUDS",
        "SCUFF", "SCULK", "SCULL", "SCULP", "SCUMS", "SCUPS", "SCURF", "SCUTA", "SCUTE", "SCUTS", "SCUZZ", "SEALS", "SEAMS", "SEAMY", "SEARS", "SEATS", "SEBUM",
        "SECCO", "SECTS", "SEDAN", "SEDER", "SEDGE", "SEDGY", "SEDUM", "SEEDS", "SEEDY", "SEEKS", "SEELS", "SEELY", "SEEMS", "SEEPS", "SEEPY", "SEERS", "SEGNI",
        "SEGNO", "SEGOS", "SEGUE", "SEIFS", "SEINE", "SEISE", "SEISM", "SEIZE", "SELAH", "SELFS", "SELLE", "SELLS", "SELVA", "SEMEN", "SEMES", "SEMIS", "SENDS",
        "SENGI", "SENNA", "SENOR", "SENSA", "SENSE", "SENTE", "SENTI", "SEPAL", "SEPIA", "SEPIC", "SEPOY", "SEPTA", "SEPTS", "SERAC", "SERAI", "SERAL", "SERED",
        "SERER", "SERES", "SERFS", "SERGE", "SERIF", "SERIN", "SEROW", "SERRY", "SERUM", "SERVE", "SERVO", "SETAE", "SETAL", "SETON", "SETTS", "SETUP", "SEVEN",
        "SEVER", "SEWAN", "SEWAR", "SEWED", "SEWER", "SEXED", "SEXES", "SEXTO", "SEXTS", "SHACK", "SHADE", "SHADS", "SHADY", "SHAFT", "SHAGS", "SHAHS", "SHAKE",
        "SHAKO", "SHAKY", "SHALE", "SHALL", "SHALT", "SHALY", "SHAME", "SHAMS", "SHANK", "SHAPE", "SHARD", "SHARE", "SHARK", "SHARN", "SHARP", "SHAUL", "SHAVE",
        "SHAWL", "SHAWM", "SHAWN", "SHAWS", "SHAYS", "SHEAF", "SHEAL", "SHEAR", "SHEAS", "SHEDS", "SHEEN", "SHEEP", "SHEER", "SHEET", "SHEIK", "SHELF", "SHELL",
        "SHEND", "SHENT", "SHEOL", "SHERD", "SHEWN", "SHEWS", "SHIED", "SHIEL", "SHIER", "SHIES", "SHIFT", "SHILL", "SHILY", "SHIMS", "SHINE", "SHINS", "SHINY",
        "SHIPS", "SHIRE", "SHIRK", "SHIRR", "SHIRT", "SHIST", "SHIVA", "SHIVE", "SHIVS", "SHLEP", "SHLUB", "SHOAL", "SHOAT", "SHOCK", "SHOED", "SHOER", "SHOES",
        "SHOGI", "SHOGS", "SHOJI", "SHONE", "SHOOK", "SHOOL", "SHOON", "SHOOS", "SHOOT", "SHOPS", "SHORE", "SHORL", "SHORN", "SHORT", "SHOTE", "SHOTS", "SHOTT",
        "SHOUT", "SHOVE", "SHOWN", "SHOWS", "SHOWY", "SHOYU", "SHRED", "SHREW", "SHRIS", "SHRUB", "SHRUG", "SHTIK", "SHUCK", "SHULN", "SHULS", "SHUNS", "SHUNT",
        "SHUSH", "SHUTE", "SHUTS", "SHWAS", "SHYER", "SHYLY", "SIALS", "SIBBS", "SIBYL", "SICES", "SICKO", "SICKS", "SIDED", "SIDES", "SIDHE", "SIDLE", "SIEGE",
        "SIEUR", "SIEVE", "SIFTS", "SIGHS", "SIGHT", "SIGIL", "SIGLA", "SIGMA", "SIGNA", "SIGNS", "SIKAS", "SIKER", "SIKES", "SILDS", "SILEX", "SILKS", "SILKY",
        "SILLS", "SILLY", "SILOS", "SILTS", "SILTY", "SILVA", "SIMAR", "SIMAS", "SIMPS", "SINCE", "SINES", "SINEW", "SINGE", "SINGS", "SINHS", "SINKS", "SINUS",
        "SIPED", "SIPES", "SIRED", "SIREE", "SIREN", "SIRES", "SIRRA", "SIRUP", "SISAL", "SISES", "SISSY", "SITAR", "SITED", "SITES", "SITUP", "SITUS", "SIVER",
        "SIXES", "SIXMO", "SIXTE", "SIXTH", "SIXTY", "SIZAR", "SIZED", "SIZER", "SIZES", "SKAGS", "SKALD", "SKANK", "SKATE", "SKATS", "SKEAN", "SKEED", "SKEEN",
        "SKEES", "SKEET", "SKEGS", "SKEIN", "SKELL", "SKELM", "SKELP", "SKENE", "SKEPS", "SKEWS", "SKIDS", "SKIED", "SKIER", "SKIES", "SKIEY", "SKIFF", "SKILL",
        "SKIMO", "SKIMP", "SKIMS", "SKINK", "SKINS", "SKINT", "SKIPS", "SKIRL", "SKIRR", "SKIRT", "SKITE", "SKITS", "SKIVE", "SKOAL", "SKORT", "SKOSH", "SKUAS",
        "SKULK", "SKULL", "SKUNK", "SKYED", "SKYEY", "SLABS", "SLACK", "SLAGS", "SLAIN", "SLAKE", "SLAMS", "SLANG", "SLANK", "SLANT", "SLAPS", "SLASH", "SLATE",
        "SLATS", "SLATY", "SLAVE", "SLAWS", "SLAYS", "SLEDS", "SLEEK", "SLEEP", "SLEET", "SLEPT", "SLEWS", "SLICE", "SLICK", "SLIDE", "SLIER", "SLILY", "SLIME",
        "SLIMS", "SLIMY", "SLING", "SLINK", "SLIPE", "SLIPS", "SLIPT", "SLITS", "SLOBS", "SLOES", "SLOGS", "SLOID", "SLOJD", "SLOOP", "SLOPE", "SLOPS", "SLOSH",
        "SLOTH", "SLOTS", "SLOWS", "SLOYD", "SLUBS", "SLUED", "SLUES", "SLUFF", "SLUGS", "SLUMP", "SLUMS", "SLUNG", "SLUNK", "SLURB", "SLURP", "SLURS", "SLUSH",
        "SLUTS", "SLYER", "SLYLY", "SLYPE", "SMACK", "SMALL", "SMALT", "SMARM", "SMART", "SMASH", "SMAZE", "SMEAR", "SMEEK", "SMELL", "SMELT", "SMERK", "SMEWS",
        "SMILE", "SMIRK", "SMITE", "SMITH", "SMOCK", "SMOGS", "SMOKE", "SMOKY", "SMOLT", "SMOTE", "SMUSH", "SMUTS", "SNACK", "SNAFU", "SNAGS", "SNAIL", "SNAKE",
        "SNAKY", "SNAPS", "SNARE", "SNARF", "SNARK", "SNARL", "SNASH", "SNATH", "SNAWS", "SNEAK", "SNEAP", "SNECK", "SNEDS", "SNEER", "SNELL", "SNIBS", "SNICK",
        "SNIDE", "SNIFF", "SNIPE", "SNIPS", "SNITS", "SNOBS", "SNOGS", "SNOOD", "SNOOK", "SNOOL", "SNOOP", "SNOOT", "SNORE", "SNORT", "SNOTS", "SNOUT", "SNOWS",
        "SNOWY", "SNUBS", "SNUCK", "SNUFF", "SNUGS", "SNYES", "SOAKS", "SOAPS", "SOAPY", "SOARS", "SOAVE", "SOBAS", "SOBER", "SOCAS", "SOCKO", "SOCKS", "SOCLE",
        "SODAS", "SODDY", "SODIC", "SODOM", "SOFAR", "SOFAS", "SOFTA", "SOFTS", "SOFTY", "SOGGY", "SOILS", "SOJAS", "SOKES", "SOKOL", "SOLAN", "SOLAR", "SOLDI",
        "SOLDO", "SOLED", "SOLEI", "SOLES", "SOLID", "SOLON", "SOLOS", "SOLUM", "SOLUS", "SOLVE", "SOMAN", "SOMAS", "SONAR", "SONDE", "SONES", "SONGS", "SONIC",
        "SONLY", "SONNY", "SONSY", "SOOEY", "SOOKS", "SOOTH", "SOOTS", "SOOTY", "SOPHS", "SOPHY", "SOPOR", "SOPPY", "SORAS", "SORBS", "SORDS", "SORED", "SOREL",
        "SORER", "SORES", "SORGO", "SORNS", "SORRY", "SORTA", "SORTS", "SORUS", "SOTHS", "SOTOL", "SOUGH", "SOUKS", "SOULS", "SOUND", "SOUPS", "SOUPY", "SOURS",
        "SOUSE", "SOUTH", "SOWAR", "SOWED", "SOWER", "SOYAS", "SOYUZ", "SOZIN", "SPACE", "SPACY", "SPADE", "SPADO", "SPAED", "SPAES", "SPAHI", "SPAIL", "SPAIT",
        "SPAKE", "SPALE", "SPALL", "SPAMS", "SPANG", "SPANK", "SPANS", "SPARE", "SPARK", "SPARS", "SPASM", "SPATE", "SPATS", "SPAWN", "SPAYS", "SPAZZ", "SPEAK",
        "SPEAN", "SPEAR", "SPECK", "SPECS", "SPEED", "SPEEL", "SPEER", "SPEIL", "SPEIR", "SPELL", "SPELT", "SPEND", "SPENT", "SPERM", "SPEWS", "SPICA", "SPICE",
        "SPICK", "SPICS", "SPICY", "SPIED", "SPIEL", "SPIER", "SPIES", "SPIFF", "SPIKE", "SPIKS", "SPIKY", "SPILE", "SPILL", "SPILT", "SPINE", "SPINS", "SPINY",
        "SPIRE", "SPIRT", "SPIRY", "SPITE", "SPITS", "SPITZ", "SPIVS", "SPLAT", "SPLAY", "SPLIT", "SPODE", "SPOIL", "SPOKE", "SPOOF", "SPOOK", "SPOOL", "SPOON",
        "SPOOR", "SPORE", "SPORT", "SPOTS", "SPOUT", "SPRAG", "SPRAT", "SPRAY", "SPREE", "SPRIG", "SPRIT", "SPRUE", "SPRUG", "SPUDS", "SPUED", "SPUES", "SPUME",
        "SPUMY", "SPUNK", "SPURN", "SPURS", "SPURT", "SPUTA", "SQUAB", "SQUAD", "SQUAT", "SQUAW", "SQUEG", "SQUIB", "SQUID", "STABS", "STACK", "STADE", "STAFF",
        "STAGE", "STAGS", "STAGY", "STAID", "STAIG", "STAIN", "STAIR", "STAKE", "STALE", "STALK", "STALL", "STAMP", "STAND", "STANE", "STANG", "STANK", "STAPH",
        "STARE", "STARK", "STARS", "START", "STASH", "STATE", "STATS", "STAVE", "STAYS", "STEAD", "STEAK", "STEAL", "STEAM", "STEED", "STEEK", "STEEL", "STEEP",
        "STEER", "STEIN", "STELA", "STELE", "STEMS", "STENO", "STENT", "STEPS", "STERE", "STERN", "STETS", "STEWS", "STEWY", "STICH", "STICK", "STIED", "STIES",
        "STIFF", "STILE", "STILL", "STILT", "STIME", "STIMY", "STING", "STINK", "STINT", "STIPE", "STIRK", "STIRP", "STIRS", "STOAE", "STOAI", "STOAS", "STOAT",
        "STOBS", "STOCK", "STOGY", "STOIC", "STOKE", "STOLE", "STOMA", "STOMP", "STONE", "STONY", "STOOD", "STOOK", "STOOL", "STOOP", "STOPE", "STOPS", "STOPT",
        "STORE", "STORK", "STORM", "STORY", "STOSS", "STOTS", "STOTT", "STOUP", "STOUR", "STOUT", "STOVE", "STOWP", "STOWS", "STRAP", "STRAW", "STRAY", "STREP",
        "STREW", "STRIA", "STRIP", "STROP", "STROW", "STROY", "STRUM", "STRUT", "STUBS", "STUCK", "STUDS", "STUDY", "STUFF", "STULL", "STUMP", "STUMS", "STUNG",
        "STUNK", "STUNS", "STUNT", "STUPA", "STUPE", "STURT", "STYED", "STYES", "STYLE", "STYLI", "STYMY", "SUAVE", "SUBAH", "SUBAS", "SUBER", "SUCKS", "SUCKY",
        "SUCRE", "SUDDS", "SUDOR", "SUDSY", "SUEDE", "SUERS", "SUETS", "SUETY", "SUGAR", "SUGHS", "SUING", "SUINT", "SUITE", "SUITS", "SULCI", "SULFA", "SULFO",
        "SULKS", "SULKY", "SULLY", "SULUS", "SUMAC", "SUMMA", "SUMOS", "SUMPS", "SUNNA", "SUNNS", "SUNNY", "SUNUP", "SUPER", "SUPES", "SUPRA", "SURAH", "SURAL",
        "SURAS", "SURDS", "SURER", "SURFS", "SURFY", "SURGE", "SURGY", "SURLY", "SURRA", "SUSHI", "SUTRA", "SUTTA", "SWABS", "SWAGE", "SWAGS", "SWAIL", "SWAIN",
        "SWALE", "SWAMI", "SWAMP", "SWAMY", "SWANG", "SWANK", "SWANS", "SWAPS", "SWARD", "SWARE", "SWARF", "SWARM", "SWART", "SWASH", "SWATH", "SWATS", "SWAYS",
        "SWEAR", "SWEAT", "SWEDE", "SWEEP", "SWEER", "SWEET", "SWELL", "SWEPT", "SWIFT", "SWIGS", "SWILL", "SWIMS", "SWINE", "SWING", "SWINK", "SWIPE", "SWIRL",
        "SWISH", "SWISS", "SWITH", "SWIVE", "SWOBS", "SWOON", "SWOOP", "SWOPS", "SWORD", "SWORE", "SWORN", "SWOTS", "SWOUN", "SWUNG", "SYCEE", "SYCES", "SYKES",
        "SYLIS", "SYLPH", "SYLVA", "SYNCH", "SYNCS", "SYNOD", "SYNTH", "SYPHS", "SYREN", "SYRUP", "SYSOP"
    };
    public static List<string> FiveLetter_T = new List<string>()
    {
        "TABBY", "TABER", "TABES", "TABID", "TABLA", "TABLE", "TABOO", "TABOR", "TABUN", "TABUS", "TACES", "TACET", "TACHE", "TACHS", "TACIT", "TACKS", "TACKY",
        "TACOS", "TACTS", "TAELS", "TAFFY", "TAFIA", "TAHRS", "TAIGA", "TAILS", "TAINS", "TAINT", "TAJES", "TAKAS", "TAKEN", "TAKER", "TAKES", "TAKIN", "TALAR",
        "TALAS", "TALCS", "TALER", "TALES", "TALKS", "TALKY", "TALLS", "TALLY", "TALON", "TALUK", "TALUS", "TAMAL", "TAMED", "TAMER", "TAMES", "TAMIS", "TAMMY",
        "TAMPS", "TANGA", "TANGO", "TANGS", "TANGY", "TANKA", "TANKS", "TANSY", "TANTO", "TAPAS", "TAPED", "TAPER", "TAPES", "TAPIR", "TAPIS", "TARDO", "TARDY",
        "TARED", "TARES", "TARGE", "TARNS", "TAROC", "TAROK", "TAROS", "TAROT", "TARPS", "TARRE", "TARRY", "TARSI", "TARTS", "TARTY", "TASKS", "TASSE", "TASTE",
        "TASTY", "TATAR", "TATER", "TATES", "TATTY", "TAUNT", "TAUON", "TAUPE", "TAUTS", "TAWED", "TAWER", "TAWIE", "TAWNY", "TAWSE", "TAXED", "TAXER", "TAXES",
        "TAXIS", "TAXOL", "TAXON", "TAXUS", "TAZZA", "TAZZE", "TEACH", "TEAKS", "TEALS", "TEAMS", "TEARS", "TEARY", "TEASE", "TEATS", "TECHS", "TECHY", "TECTA",
        "TEDDY", "TEELS", "TEEMS", "TEENS", "TEENY", "TEETH", "TEFFS", "TEGGS", "TEGUA", "TEIID", "TEIND", "TELAE", "TELCO", "TELES", "TELEX", "TELIA", "TELIC",
        "TELLS", "TELLY", "TELOI", "TELOS", "TEMPI", "TEMPO", "TEMPS", "TEMPT", "TENCH", "TENDS", "TENDU", "TENET", "TENGE", "TENIA", "TENON", "TENOR", "TENSE",
        "TENTH", "TENTS", "TENTY", "TEPAL", "TEPAS", "TEPEE", "TEPID", "TEPOY", "TERAI", "TERCE", "TERGA", "TERMS", "TERNE", "TERNS", "TERRA", "TERRY", "TERSE",
        "TESLA", "TESTA", "TESTS", "TESTY", "TETHS", "TETRA", "TETRI", "TEUCH", "TEUGH", "TEWED", "TEXAS", "TEXTS", "THACK", "THANE", "THANK", "THARM", "THAWS",
        "THEBE", "THECA", "THEFT", "THEGN", "THEIN", "THEIR", "THEME", "THENS", "THERE", "THERM", "THESE", "THESP", "THETA", "THEWS", "THEWY", "THICK", "THIEF",
        "THIGH", "THILL", "THINE", "THING", "THINK", "THINS", "THIOL", "THIRD", "THIRL", "THOLE", "THONG", "THORN", "THORO", "THORP", "THOSE", "THOUS", "THRAW",
        "THREE", "THREW", "THRIP", "THROB", "THROE", "THROW", "THRUM", "THUDS", "THUGS", "THUJA", "THUMB", "THUMP", "THUNK", "THURL", "THUYA", "THYME", "THYMI",
        "THYMY", "TIARA", "TIBIA", "TICAL", "TICKS", "TIDAL", "TIDED", "TIDES", "TIERS", "TIFFS", "TIGER", "TIGHT", "TIGON", "TIKES", "TIKIS", "TIKKA", "TILAK",
        "TILDE", "TILED", "TILER", "TILES", "TILLS", "TILTH", "TILTS", "TIMED", "TIMER", "TIMES", "TIMID", "TINCT", "TINEA", "TINED", "TINES", "TINGE", "TINGS",
        "TINNY", "TINTS", "TIPIS", "TIPPY", "TIPSY", "TIRED", "TIRES", "TIRLS", "TIROS", "TITAN", "TITER", "TITHE", "TITIS", "TITLE", "TITRE", "TITTY", "TIZZY",
        "TOADS", "TOADY", "TOAST", "TODAY", "TODDY", "TOEAS", "TOFFS", "TOFFY", "TOFTS", "TOFUS", "TOGAE", "TOGAS", "TOGUE", "TOILE", "TOILS", "TOITS", "TOKAY",
        "TOKED", "TOKEN", "TOKER", "TOKES", "TOLAN", "TOLAR", "TOLAS", "TOLED", "TOLES", "TOLLS", "TOLUS", "TOLYL", "TOMAN", "TOMBS", "TOMES", "TOMMY", "TONAL",
        "TONDI", "TONDO", "TONED", "TONER", "TONES", "TONEY", "TONGA", "TONGS", "TONIC", "TONNE", "TONUS", "TOOLS", "TOONS", "TOOTH", "TOOTS", "TOPAZ", "TOPED",
        "TOPEE", "TOPER", "TOPES", "TOPHE", "TOPHI", "TOPHS", "TOPIC", "TOPIS", "TOPOI", "TOPOS", "TOQUE", "TORAH", "TORAS", "TORCH", "TORCS", "TORES", "TORIC",
        "TORII", "TOROS", "TOROT", "TORRS", "TORSE", "TORSI", "TORSK", "TORSO", "TORTA", "TORTE", "TORTS", "TORUS", "TOTAL", "TOTED", "TOTEM", "TOTER", "TOTES",
        "TOUCH", "TOUGH", "TOURS", "TOUSE", "TOUTS", "TOWED", "TOWEL", "TOWER", "TOWIE", "TOWNS", "TOWNY", "TOXIC", "TOXIN", "TOYED", "TOYER", "TOYON", "TOYOS",
        "TRACE", "TRACK", "TRACT", "TRADE", "TRAGI", "TRAIK", "TRAIL", "TRAIN", "TRAIT", "TRAMP", "TRAMS", "TRANK", "TRANQ", "TRANS", "TRAPS", "TRAPT", "TRASH",
        "TRASS", "TRAVE", "TRAWL", "TRAYS", "TREAD", "TREAT", "TREED", "TREEN", "TREES", "TREKS", "TREND", "TRESS", "TRETS", "TREWS", "TREYS", "TRIAC", "TRIAD",
        "TRIAL", "TRIBE", "TRICE", "TRICK", "TRIED", "TRIER", "TRIES", "TRIGO", "TRIGS", "TRIKE", "TRILL", "TRIMS", "TRINE", "TRIOL", "TRIOS", "TRIPE", "TRIPS",
        "TRITE", "TROAK", "TROCK", "TRODE", "TROGS", "TROIS", "TROKE", "TROLL", "TROMP", "TRONA", "TRONE", "TROOP", "TROOZ", "TROPE", "TROTH", "TROTS", "TROUT",
        "TROVE", "TROWS", "TROYS", "TRUCE", "TRUCK", "TRUED", "TRUER", "TRUES", "TRUGS", "TRULL", "TRULY", "TRUMP", "TRUNK", "TRUSS", "TRUST", "TRUTH", "TRYMA",
        "TRYST", "TSADE", "TSADI", "TSARS", "TSKED", "TSUBA", "TUBAE", "TUBAL", "TUBAS", "TUBBY", "TUBED", "TUBER", "TUBES", "TUCKS", "TUFAS", "TUFFS", "TUFTS",
        "TUFTY", "TULES", "TULIP", "TULLE", "TUMID", "TUMMY", "TUMOR", "TUMPS", "TUNAS", "TUNED", "TUNER", "TUNES", "TUNGS", "TUNIC", "TUNNY", "TUPIK", "TUQUE",
        "TURBO", "TURDS", "TURFS", "TURFY", "TURKS", "TURNS", "TURPS", "TUSHY", "TUSKS", "TUTEE", "TUTOR", "TUTTI", "TUTTY", "TUTUS", "TUXES", "TUYER", "TWAES",
        "TWAIN", "TWANG", "TWATS", "TWEAK", "TWEED", "TWEEN", "TWEET", "TWERP", "TWICE", "TWIER", "TWIGS", "TWILL", "TWINE", "TWINS", "TWINY", "TWIRL", "TWIRP",
        "TWIST", "TWITS", "TWIXT", "TWYER", "TYEES", "TYERS", "TYING", "TYIYN", "TYKES", "TYNED", "TYNES", "TYPAL", "TYPED", "TYPES", "TYPEY", "TYPIC", "TYPOS",
        "TYPPS", "TYRED", "TYRES", "TYROS", "TYTHE", "TZARS"
    };
    public static List<string> FiveLetter_U = new List<string>()
    {
        "UDDER", "UDONS", "UHLAN", "UKASE", "ULAMA", "ULANS", "ULCER", "ULEMA", "ULNAD", "ULNAE", "ULNAR", "ULNAS", "ULPAN", "ULTRA", "ULVAS", "UMAMI", "UMBEL",
        "UMBER", "UMBOS", "UMBRA", "UMIAC", "UMIAK", "UMIAQ", "UMPED", "UNAIS", "UNAPT", "UNARM", "UNARY", "UNAUS", "UNBAN", "UNBAR", "UNBID", "UNBOX", "UNCAP",
        "UNCIA", "UNCLE", "UNCOS", "UNCOY", "UNCUS", "UNCUT", "UNDEE", "UNDER", "UNDID", "UNDUE", "UNFED", "UNFIT", "UNFIX", "UNGOT", "UNHAT", "UNHIP", "UNIFY",
        "UNION", "UNITE", "UNITS", "UNITY", "UNJAM", "UNLAY", "UNLED", "UNLET", "UNLIT", "UNMAN", "UNMET", "UNMEW", "UNMIX", "UNPEG", "UNPEN", "UNPIN", "UNRIG",
        "UNRIP", "UNSAY", "UNSET", "UNSEW", "UNSEX", "UNTIE", "UNTIL", "UNWED", "UNWET", "UNWIT", "UNWON", "UNZIP", "UPBOW", "UPBYE", "UPDOS", "UPDRY", "UPEND",
        "UPLIT", "UPPED", "UPPER", "UPSET", "URAEI", "URARE", "URARI", "URASE", "URATE", "URBAN", "URBIA", "UREAL", "UREAS", "UREDO", "UREIC", "URGED", "URGER",
        "URGES", "URIAL", "URINE", "URPED", "URSAE", "URSID", "USAGE", "USERS", "USHER", "USING", "USNEA", "USQUE", "USUAL", "USURP", "USURY", "UTERI", "UTILE",
        "UTTER", "UVEAL", "UVEAS", "UVULA"
    };
    public static List<string> FiveLetter_V = new List<string>()
    {
        "VACUA", "VAGAL", "VAGUE", "VAGUS", "VAILS", "VAIRS", "VAKIL", "VALES", "VALET", "VALID", "VALOR", "VALSE", "VALUE", "VALVE", "VAMPS", "VAMPY", "VANDA",
        "VANED", "VANES", "VANGS", "VAPID", "VAPOR", "VARAS", "VARIA", "VARIX", "VARNA", "VARUS", "VARVE", "VASAL", "VASES", "VASTS", "VASTY", "VATIC", "VATUS",
        "VAULT", "VAUNT", "VEALS", "VEALY", "VEENA", "VEEPS", "VEERS", "VEERY", "VEGAN", "VEGES", "VEGIE", "VEILS", "VEINS", "VEINY", "VELAR", "VELDS", "VELDT",
        "VELUM", "VENAE", "VENAL", "VENDS", "VENGE", "VENIN", "VENOM", "VENTS", "VENUE", "VENUS", "VERBS", "VERGE", "VERSE", "VERSO", "VERST", "VERTS", "VERTU",
        "VERVE", "VESTA", "VESTS", "VETCH", "VEXED", "VEXER", "VEXES", "VEXIL", "VIALS", "VIAND", "VIBES", "VICAR", "VICED", "VICES", "VICHY", "VIDEO", "VIERS",
        "VIEWS", "VIEWY", "VIGAS", "VIGIA", "VIGIL", "VIGOR", "VILER", "VILLA", "VILLI", "VILLS", "VIMEN", "VINAL", "VINAS", "VINCA", "VINED", "VINES", "VINIC",
        "VINOS", "VINYL", "VIOLA", "VIOLS", "VIPER", "VIRAL", "VIREO", "VIRES", "VIRGA", "VIRID", "VIRLS", "VIRTU", "VIRUS", "VISAS", "VISED", "VISES", "VISIT",
        "VISOR", "VISTA", "VITAE", "VITAL", "VITTA", "VIVAS", "VIVID", "VIXEN", "VIZIR", "VIZOR", "VOCAB", "VOCAL", "VOCES", "VODKA", "VODOU", "VODUN", "VOGIE",
        "VOGUE", "VOICE", "VOIDS", "VOILA", "VOILE", "VOLAR", "VOLED", "VOLES", "VOLTA", "VOLTE", "VOLTI", "VOLTS", "VOLVA", "VOMER", "VOMIT", "VOTED", "VOTER",
        "VOTES", "VOUCH", "VOWED", "VOWEL", "VOWER", "VROOM", "VROUW", "VROWS", "VUGGS", "VUGGY", "VUGHS", "VULGO", "VULVA", "VYING"
    };
    public static List<string> FiveLetter_W = new List<string>()
    {
        "WACKE", "WACKO", "WACKS", "WACKY", "WADDY", "WADED", "WADER", "WADES", "WADIS", "WAFER", "WAFFS", "WAFTS", "WAGED", "WAGER", "WAGES", "WAGON", "WAHOO",
        "WAIFS", "WAILS", "WAINS", "WAIRS", "WAIST", "WAITS", "WAIVE", "WAKED", "WAKEN", "WAKER", "WAKES", "WALED", "WALER", "WALES", "WALKS", "WALLA", "WALLS",
        "WALLY", "WALTZ", "WAMES", "WAMUS", "WANDS", "WANED", "WANES", "WANEY", "WANKS", "WANLY", "WANTS", "WARDS", "WARED", "WARES", "WARKS", "WARMS", "WARNS",
        "WARPS", "WARTS", "WARTY", "WASHY", "WASPS", "WASPY", "WASTE", "WASTS", "WATAP", "WATCH", "WATER", "WATTS", "WAUGH", "WAUKS", "WAULS", "WAVED", "WAVER",
        "WAVES", "WAVEY", "WAWLS", "WAXED", "WAXEN", "WAXER", "WAXES", "WAZOO", "WEALD", "WEALS", "WEANS", "WEARS", "WEARY", "WEAVE", "WEBBY", "WEBER", "WECHT",
        "WEDEL", "WEDGE", "WEDGY", "WEEDS", "WEEDY", "WEEKS", "WEENS", "WEENY", "WEEPS", "WEEPY", "WEEST", "WEETS", "WEFTS", "WEIGH", "WEIRD", "WEIRS", "WEKAS",
        "WELCH", "WELDS", "WELLS", "WELLY", "WELSH", "WELTS", "WENCH", "WENDS", "WENNY", "WESTS", "WETLY", "WHACK", "WHALE", "WHAMO", "WHAMS", "WHANG", "WHAPS",
        "WHARF", "WHATS", "WHAUP", "WHEAL", "WHEAT", "WHEEL", "WHEEN", "WHEEP", "WHELK", "WHELM", "WHELP", "WHENS", "WHERE", "WHETS", "WHEWS", "WHEYS", "WHICH",
        "WHIDS", "WHIFF", "WHIGS", "WHILE", "WHIMS", "WHINE", "WHINS", "WHINY", "WHIPS", "WHIPT", "WHIRL", "WHIRR", "WHIRS", "WHISH", "WHISK", "WHIST", "WHITE",
        "WHITS", "WHITY", "WHIZZ", "WHOLE", "WHOMP", "WHOOF", "WHOOP", "WHOPS", "WHORL", "WHORT", "WHOSE", "WHOSO", "WHUMP", "WHUPS", "WICCA", "WICKS", "WIDDY",
        "WIDEN", "WIDER", "WIDES", "WIDOW", "WIDTH", "WIELD", "WIFED", "WIFES", "WIFEY", "WIFTY", "WIGAN", "WIGGY", "WIGHT", "WILCO", "WILDS", "WILED", "WILES",
        "WILLS", "WILLY", "WILTS", "WIMPS", "WIMPY", "WINCE", "WINCH", "WINDS", "WINDY", "WINED", "WINES", "WINEY", "WINGS", "WINGY", "WINKS", "WINOS", "WINZE",
        "WIPED", "WIPER", "WIPES", "WIRED", "WIRER", "WIRES", "WIRRA", "WISED", "WISER", "WISES", "WISHA", "WISPS", "WISPY", "WISTS", "WITAN", "WITCH", "WITED",
        "WITES", "WITHE", "WITHY", "WITTY", "WIVED", "WIVER", "WIVES", "WIZEN", "WIZES", "WOADS", "WOALD", "WODGE", "WOFUL", "WOKEN", "WOLDS", "WOLFS", "WOMAN",
        "WOMBS", "WOMBY", "WOMEN", "WOMYN", "WONKS", "WONKY", "WONTS", "WOODS", "WOODY", "WOOED", "WOOER", "WOOFS", "WOOLS", "WOOLY", "WOOPS", "WOOSH", "WOOZY",
        "WORDS", "WORDY", "WORKS", "WORLD", "WORMS", "WORMY", "WORRY", "WORSE", "WORST", "WORTH", "WORTS", "WOULD", "WOUND", "WOVEN", "WOWED", "WRACK", "WRANG",
        "WRAPS", "WRAPT", "WRATH", "WREAK", "WRECK", "WRENS", "WREST", "WRICK", "WRIED", "WRIER", "WRIES", "WRING", "WRIST", "WRITE", "WRITS", "WRONG", "WROTE",
        "WROTH", "WRUNG", "WRYER", "WRYLY", "WURST", "WUSHU", "WUSSY", "WYLED", "WYLES", "WYNDS", "WYNNS", "WYTED", "WYTES"
    };
    public static List<string> FiveLetter_X = new List<string>()
    {
        "XEBEC", "XENIA", "XENIC", "XENON", "XERIC", "XEROX", "XERUS", "XYLAN", "XYLEM", "XYLOL", "XYLYL", "XYSTI", "XYSTS"
    };
    public static List<string> FiveLetter_Y = new List<string>()
    {
        "YABBY", "YACHT", "YACKS", "YAFFS", "YAGER", "YAGIS", "YAHOO", "YAIRD", "YAMEN", "YAMUN", "YANGS", "YANKS", "YAPOK", "YAPON", "YARDS", "YARER", "YARNS",
        "YAUDS", "YAULD", "YAUPS", "YAWED", "YAWEY", "YAWLS", "YAWNS", "YAWPS", "YCLAD", "YEAHS", "YEANS", "YEARN", "YEARS", "YEAST", "YECCH", "YECHS", "YECHY",
        "YEGGS", "YELKS", "YELLS", "YELPS", "YENTA", "YENTE", "YERBA", "YERKS", "YESES", "YETIS", "YETTS", "YEUKS", "YEUKY", "YIELD", "YIKES", "YILLS", "YINCE",
        "YIPES", "YIRDS", "YIRRS", "YIRTH", "YLEMS", "YOBBO", "YOCKS", "YODEL", "YODHS", "YODLE", "YOGAS", "YOGEE", "YOGHS", "YOGIC", "YOGIN", "YOGIS", "YOKED",
        "YOKEL", "YOKES", "YOLKS", "YOLKY", "YOMIM", "YONIC", "YONIS", "YORES", "YOUNG", "YOURN", "YOURS", "YOUSE", "YOUTH", "YOWED", "YOWES", "YOWIE", "YOWLS",
        "YUANS", "YUCAS", "YUCCA", "YUCCH", "YUCKS", "YUCKY", "YUGAS", "YUKKY", "YULAN", "YULES", "YUMMY", "YUPON", "YUPPY", "YURTA", "YURTS"
    };
    public static List<string> FiveLetter_Z = new List<string>()
    {
        "ZAIRE", "ZAMIA", "ZANZA", "ZAPPY", "ZARFS", "ZAXES", "ZAYIN", "ZAZEN", "ZEALS", "ZEBEC", "ZEBRA", "ZEBUS", "ZEINS", "ZERKS", "ZEROS", "ZESTS", "ZESTY",
        "ZETAS", "ZIBET", "ZILCH", "ZILLS", "ZINCS", "ZINCY", "ZINEB", "ZINES", "ZINGS", "ZINGY", "ZINKY", "ZIPPY", "ZIRAM", "ZITIS", "ZIZIT", "ZLOTE", "ZLOTY",
        "ZOEAE", "ZOEAL", "ZOEAS", "ZOMBI", "ZONAE", "ZONAL", "ZONED", "ZONER", "ZONES", "ZONKS", "ZOOEY", "ZOOID", "ZOOKS", "ZOOMS", "ZOONS", "ZOOTY", "ZORIL",
        "ZORIS", "ZOUKS", "ZOWIE", "ZUZIM", "ZYMES"
    };

    public static List<List<string>> ThreeLetterWords = new List<List<string>>()
    {
        ThreeLetter_A, ThreeLetter_B, ThreeLetter_C, ThreeLetter_D, ThreeLetter_E, ThreeLetter_F, ThreeLetter_G, ThreeLetter_H, ThreeLetter_I,
        ThreeLetter_J, ThreeLetter_K, ThreeLetter_L, ThreeLetter_M, ThreeLetter_N, ThreeLetter_O, ThreeLetter_P, ThreeLetter_Q, ThreeLetter_R,
        ThreeLetter_S, ThreeLetter_T, ThreeLetter_U, ThreeLetter_V, ThreeLetter_W, ThreeLetter_X, ThreeLetter_Y, ThreeLetter_Z
    };
    public static List<List<string>> FourLetterWords = new List<List<string>>()
    {
        FourLetter_A, FourLetter_B, FourLetter_C, FourLetter_D, FourLetter_E, FourLetter_F, FourLetter_G, FourLetter_H, FourLetter_I, FourLetter_J,
        FourLetter_K, FourLetter_L, FourLetter_M, FourLetter_N, FourLetter_O, FourLetter_P, FourLetter_Q, FourLetter_R, FourLetter_S, FourLetter_T,
        FourLetter_U, FourLetter_V, FourLetter_W, FourLetter_X, FourLetter_Y, FourLetter_Z
    };
    public static List<List<string>> FiveLetterWords = new List<List<string>>()
    {
        FiveLetter_A, FiveLetter_B, FiveLetter_C, FiveLetter_D, FiveLetter_E, FiveLetter_F, FiveLetter_G, FiveLetter_H, FiveLetter_I, FiveLetter_J,
        FiveLetter_K, FiveLetter_L, FiveLetter_M, FiveLetter_N, FiveLetter_O, FiveLetter_P, FiveLetter_Q, FiveLetter_R, FiveLetter_S, FiveLetter_T,
        FiveLetter_U, FiveLetter_V, FiveLetter_W, FiveLetter_X, FiveLetter_Y, FiveLetter_Z
    };


    public static List<string> GetWordList(int letterCount, string startLetter)
    {
        int index = alphabet.IndexOf(startLetter);

        if (letterCount == 3) return ThreeLetterWords[index];
        if (letterCount == 4) return FourLetterWords[index];
        if (letterCount == 5) return FiveLetterWords[index];
        return null;
    }
}
