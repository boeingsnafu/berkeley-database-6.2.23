/* DO NOT EDIT: automatically built by dist/s_csharp_const. */

namespace BerkeleyDB.Internal {

    internal class DbConstants {
        internal const uint DB_AFTER = 1;
        internal const uint DB_AGGRESSIVE = 0x00000001;
        internal const uint DB_APPEND = 2;
        internal const uint DB_ARCH_ABS = 0x00000001;
        internal const uint DB_ARCH_DATA = 0x00000002;
        internal const uint DB_ARCH_LOG = 0x00000004;
        internal const uint DB_ARCH_REMOVE = 0x00000008;
        internal const uint DB_ASSOC_IMMUTABLE_KEY = 0x00000001;
        internal const uint DB_ASSOC_CREATE = 0x00000002;
        internal const uint DB_AUTO_COMMIT = 0x00000100;
        internal const uint DB_BACKUP_CLEAN = 0x00000002;
        internal const uint DB_BACKUP_FILES = 0x00000008;
        internal const uint DB_BACKUP_NO_LOGS = 0x00000010;
        internal const uint DB_BACKUP_READ_COUNT = 1;
        internal const uint DB_BACKUP_READ_SLEEP = 2;
        internal const uint DB_BACKUP_SINGLE_DIR = 0x00000020;
        internal const uint DB_BACKUP_SIZE = 3;
        internal const uint DB_BACKUP_UPDATE = 0x00000040;
        internal const uint DB_BACKUP_WRITE_DIRECT = 4;
        internal const uint DB_BEFORE = 3;
        internal const uint DB_BOOTSTRAP_HELPER = 0x00000001;
        internal const uint DB_BTREE = 1;
        internal const int DB_BUFFER_SMALL = -30999;
        internal const uint DB_CDB_ALLDB = 0x00000040;
        internal const uint DB_CHKSUM = 0x00000008;
        internal const uint DB_CONSUME = 4;
        internal const uint DB_CONSUME_WAIT = 5;
        internal const uint DB_CREATE = 0x00000001;
        internal const uint DB_CURRENT = 6;
        internal const uint DB_CURSOR_BULK = 0x00000001;
        internal const uint DB_DBT_APPMALLOC = 0x0001;
        internal const uint DB_DBT_BLOB = 0x1000;
        internal const uint DB_DBT_BULK = 0x0002;
        internal const uint DB_DBT_EXT_FILE = 0x1000;
        internal const uint DB_DBT_MALLOC = 0x0010;
        internal const uint DB_DBT_MULTIPLE = 0x0020;
        internal const uint DB_DBT_PARTIAL = 0x0040;
        internal const uint DB_DBT_READONLY = 0x0100;
        internal const uint DB_DBT_REALLOC = 0x0080;
        internal const uint DB_DBT_USERCOPY = 0x0400;
        internal const uint DB_DBT_USERMEM = 0x0800;
        internal const uint DB_DIRECT_DB = 0x00000200;
        internal const int DB_DONOTINDEX = -30998;
        internal const uint DB_DSYNC_DB = 0x00000400;
        internal const uint DB_DUP = 0x00000010;
        internal const uint DB_DUPSORT = 0x00000002;
        internal const int DB_EID_BROADCAST = -1;
        internal const int DB_EID_INVALID = -2;
        internal const int DB_EID_MASTER = -3;
        internal const uint DB_ENCRYPT = 0x00000001;
        internal const uint DB_ENCRYPT_AES = 0x00000001;
        internal const uint DB_EVENT_PANIC = 0;
        internal const uint DB_EVENT_REP_AUTOTAKEOVER_FAILED = 3;
        internal const uint DB_EVENT_REP_CLIENT = 4;
        internal const uint DB_EVENT_REP_CONNECT_BROKEN = 5;
        internal const uint DB_EVENT_REP_CONNECT_ESTD = 6;
        internal const uint DB_EVENT_REP_CONNECT_TRY_FAILED = 7;
        internal const uint DB_EVENT_REP_DUPMASTER = 8;
        internal const uint DB_EVENT_REP_ELECTED = 9;
        internal const uint DB_EVENT_REP_ELECTION_FAILED = 10;
        internal const uint DB_EVENT_REP_INIT_DONE = 11;
        internal const uint DB_EVENT_REP_INQUEUE_FULL = 12;
        internal const uint DB_EVENT_REP_JOIN_FAILURE = 13;
        internal const uint DB_EVENT_REP_LOCAL_SITE_REMOVED = 14;
        internal const uint DB_EVENT_REP_MASTER = 15;
        internal const uint DB_EVENT_REP_MASTER_FAILURE = 16;
        internal const uint DB_EVENT_REP_NEWMASTER = 17;
        internal const uint DB_EVENT_REP_PERM_FAILED = 18;
        internal const uint DB_EVENT_REP_SITE_ADDED = 19;
        internal const uint DB_EVENT_REP_SITE_REMOVED = 20;
        internal const uint DB_EVENT_REP_STARTUPDONE = 21;
        internal const uint DB_EVENT_WRITE_FAILED = 23;
        internal const uint DB_EXCL = 0x00000004;
        internal const uint DB_FAST_STAT = 0x00000001;
        internal const uint DB_FIRST = 7;
        internal const uint DB_FLUSH = 0x00000002;
        internal const uint DB_FORCE = 0x00000001;
        internal const uint DB_FORCESYNC = 0x00000001;
        internal const uint DB_FORCESYNCENV = 0x00000002;
        internal const uint DB_FOREIGN_ABORT = 0x00000001;
        internal const uint DB_FOREIGN_CASCADE = 0x00000002;
        internal const int DB_FOREIGN_CONFLICT = -30997;
        internal const uint DB_FOREIGN_NULLIFY = 0x00000004;
        internal const uint DB_FREELIST_ONLY = 0x00000001;
        internal const uint DB_FREE_SPACE = 0x00000002;
        internal const uint DB_GET_BOTH = 8;
        internal const uint DB_GET_BOTH_RANGE = 10;
        internal const uint DB_GET_RECNO = 11;
        internal const uint DB_GID_SIZE = 128;
        internal const uint DB_GROUP_CREATOR = 0x00000002;
        internal const uint DB_HASH = 2;
        internal const uint DB_HEAP = 6;
        internal const int DB_HEAP_FULL = -30996;
        internal const uint DB_HOTBACKUP_IN_PROGRESS = 0x00000800;
        internal const uint DB_IGNORE_LEASE = 0x00001000;
        internal const uint DB_IMMUTABLE_KEY = 0x00000002;
        internal const uint DB_INIT_CDB = 0x00000080;
        internal const uint DB_INIT_LOCK = 0x00000100;
        internal const uint DB_INIT_LOG = 0x00000200;
        internal const uint DB_INIT_MPOOL = 0x00000400;
        internal const uint DB_INIT_REP = 0x00001000;
        internal const uint DB_INIT_TXN = 0x00002000;
        internal const uint DB_INORDER = 0x00000020;
        internal const uint DB_JOINENV = 0x0;
        internal const uint DB_JOIN_ITEM = 12;
        internal const uint DB_JOIN_NOSORT = 0x00000001;
        internal const int DB_KEYEMPTY = -30995;
        internal const int DB_KEYEXIST = -30994;
        internal const uint DB_KEYFIRST = 13;
        internal const uint DB_KEYLAST = 14;
        internal const uint DB_LAST = 15;
        internal const uint DB_LEGACY = 0x00000004;
        internal const uint DB_LOCAL_SITE = 0x00000008;
        internal const uint DB_LOCKDOWN = 0x00004000;
        internal const int DB_LOCK_DEADLOCK = -30993;
        internal const uint DB_LOCK_DEFAULT = 1;
        internal const uint DB_LOCK_EXPIRE = 2;
        internal const uint DB_LOCK_GET = 1;
        internal const uint DB_LOCK_GET_TIMEOUT = 2;
        internal const uint DB_LOCK_IREAD = 5;
        internal const uint DB_LOCK_IWR = 6;
        internal const uint DB_LOCK_IWRITE = 4;
        internal const uint DB_LOCK_MAXLOCKS = 3;
        internal const uint DB_LOCK_MAXWRITE = 4;
        internal const uint DB_LOCK_MINLOCKS = 5;
        internal const uint DB_LOCK_MINWRITE = 6;
        internal const int DB_LOCK_NOTGRANTED = -30992;
        internal const uint DB_LOCK_NOWAIT = 0x00000004;
        internal const uint DB_LOCK_OLDEST = 7;
        internal const uint DB_LOCK_PUT = 4;
        internal const uint DB_LOCK_PUT_ALL = 5;
        internal const uint DB_LOCK_PUT_OBJ = 6;
        internal const uint DB_LOCK_RANDOM = 8;
        internal const uint DB_LOCK_READ = 1;
        internal const uint DB_LOCK_TIMEOUT = 8;
        internal const uint DB_LOCK_WRITE = 2;
        internal const uint DB_LOCK_YOUNGEST = 9;
        internal const uint DB_LOG_AUTO_REMOVE = 0x00000001;
        internal const uint DB_LOG_BLOB = 0x00000008;
        internal const int DB_LOG_BUFFER_FULL = -30991;
        internal const uint DB_LOG_DIRECT = 0x00000002;
        internal const uint DB_LOG_DSYNC = 0x00000004;
        internal const uint DB_LOG_EXT_FILE = 0x00000008;
        internal const uint DB_LOG_IN_MEMORY = 0x00000010;
        internal const uint DB_LOG_NOSYNC = 0x00000020;
        internal const uint DB_LOG_ZERO = 0x00000040;
        internal const uint DB_MEM_LOCK = 1;
        internal const uint DB_MEM_LOCKOBJECT = 2;
        internal const uint DB_MEM_LOCKER = 3;
        internal const uint DB_MEM_LOGID = 4;
        internal const uint DB_MEM_TRANSACTION = 5;
        internal const uint DB_MEM_THREAD = 6;
        internal const int DB_META_CHKSUM_FAIL = -30989;
        internal const uint DB_MPOOL_NOFILE = 0x00000001;
        internal const uint DB_MPOOL_UNLINK = 0x00000002;
        internal const uint DB_MULTIPLE = 0x00000800;
        internal const uint DB_MULTIPLE_KEY = 0x00004000;
        internal const uint DB_MULTIVERSION = 0x00000008;
        internal const uint DB_MUTEX_PROCESS_ONLY = 0x00000008;
        internal const uint DB_MUTEX_SELF_BLOCK = 0x00000010;
        internal const uint DB_NEXT = 16;
        internal const uint DB_NEXT_DUP = 17;
        internal const uint DB_NEXT_NODUP = 18;
        internal const uint DB_NODUPDATA = 19;
        internal const uint DB_NOLOCKING = 0x00002000;
        internal const uint DB_NOMMAP = 0x00000010;
        internal const uint DB_NOORDERCHK = 0x00000002;
        internal const uint DB_NOOVERWRITE = 20;
        internal const uint DB_NOPANIC = 0x00004000;
        internal const int DB_NOSERVER = -30988;
        internal const uint DB_NOSYNC = 0x00000001;
        internal const int DB_NOTFOUND = -30987;
        internal const int DB_OLD_VERSION = -30986;
        internal const uint DB_ORDERCHKONLY = 0x00000004;
        internal const uint DB_OVERWRITE = 0x00008000;
        internal const int DB_PAGE_NOTFOUND = -30985;
        internal const uint DB_PANIC_ENVIRONMENT = 0x00010000;
        internal const uint DB_POSITION = 22;
        internal const uint DB_PREV = 23;
        internal const uint DB_PREV_DUP = 24;
        internal const uint DB_PREV_NODUP = 25;
        internal const uint DB_PRINTABLE = 0x00000008;
        internal const uint DB_PRIORITY_DEFAULT = 3;
        internal const uint DB_PRIORITY_HIGH = 4;
        internal const uint DB_PRIORITY_LOW = 2;
        internal const uint DB_PRIORITY_VERY_HIGH = 5;
        internal const uint DB_PRIORITY_VERY_LOW = 1;
        internal const uint DB_PRIVATE = 0x00010000;
        internal const uint DB_QUEUE = 4;
        internal const uint DB_RDONLY = 0x00000400;
        internal const uint DB_READ_COMMITTED = 0x00000400;
        internal const uint DB_READ_UNCOMMITTED = 0x00000200;
        internal const uint DB_RECNO = 3;
        internal const uint DB_RECNUM = 0x00000040;
        internal const uint DB_RECOVER = 0x00000002;
        internal const uint DB_RECOVER_FATAL = 0x00020000;
        internal const uint DB_REGION_INIT = 0x00020000;
        internal const uint DB_REGISTER = 0x00040000;
        internal const uint DB_RENUMBER = 0x00000080;
        internal const int DB_REPMGR_ACKS_ALL = 1;
        internal const int DB_REPMGR_ACKS_ALL_AVAILABLE = 2;
        internal const int DB_REPMGR_ACKS_ALL_PEERS = 3;
        internal const int DB_REPMGR_ACKS_NONE = 4;
        internal const int DB_REPMGR_ACKS_ONE = 5;
        internal const int DB_REPMGR_ACKS_ONE_PEER = 6;
        internal const int DB_REPMGR_ACKS_QUORUM = 7;
        internal const uint DB_REPMGR_CONF_2SITE_STRICT = 0x00000001;
        internal const uint DB_REPMGR_CONF_ELECTIONS = 0x00000002;
        internal const uint DB_REPMGR_CONF_FORWARD_WRITES = 0x00000004;
        internal const uint DB_REPMGR_CONF_PREFMAS_CLIENT = 0x00000008;
        internal const uint DB_REPMGR_CONF_PREFMAS_MASTER = 0x00000010;
        internal const uint DB_REPMGR_CONNECTED = 1;
        internal const uint DB_REPMGR_DISCONNECTED = 2;
        internal const uint DB_REPMGR_NEED_RESPONSE = 0x00000001;
        internal const uint DB_REPMGR_ISPEER = 0x01;
        internal const uint DB_REPMGR_ISVIEW = 0x02;
        internal const uint DB_REPMGR_PEER = 0x00000010;
        internal const int DB_REP_ACK_TIMEOUT = 1;
        internal const uint DB_REP_ANYWHERE = 0x00000001;
        internal const int DB_REP_CHECKPOINT_DELAY = 2;
        internal const uint DB_REP_CLIENT = 0x00000001;
        internal const uint DB_REP_CONF_AUTOINIT = 0x00000020;
        internal const uint DB_REP_CONF_BULK = 0x00000080;
        internal const uint DB_REP_CONF_DELAYCLIENT = 0x00000100;
        internal const uint DB_REP_CONF_INMEM = 0x00000400;
        internal const uint DB_REP_CONF_LEASE = 0x00000800;
        internal const uint DB_REP_CONF_NOWAIT = 0x00001000;
        internal const int DB_REP_CONNECTION_RETRY = 3;
        internal const uint DB_REP_DEFAULT_PRIORITY = 100;
        internal const int DB_REP_DUPMASTER = -30984;
        internal const uint DB_REP_ELECTION = 0x00000004;
        internal const int DB_REP_ELECTION_RETRY = 4;
        internal const int DB_REP_ELECTION_TIMEOUT = 5;
        internal const int DB_REP_FULL_ELECTION_TIMEOUT = 6;
        internal const int DB_REP_HANDLE_DEAD = -30983;
        internal const int DB_REP_HEARTBEAT_MONITOR = 7;
        internal const int DB_REP_HEARTBEAT_SEND = 8;
        internal const int DB_REP_HOLDELECTION = -30982;
        internal const int DB_REP_IGNORE = -30981;
        internal const int DB_REP_ISPERM = -30980;
        internal const int DB_REP_JOIN_FAILURE = -30979;
        internal const int DB_REP_LEASE_EXPIRED = -30978;
        internal const int DB_REP_LEASE_TIMEOUT = 9;
        internal const int DB_REP_LOCKOUT = -30977;
        internal const uint DB_REP_MASTER = 0x00000002;
        internal const int DB_REP_NEWSITE = -30976;
        internal const uint DB_REP_NOBUFFER = 0x00000002;
        internal const int DB_REP_NOTPERM = -30975;
        internal const uint DB_REP_PERMANENT = 0x00000004;
        internal const uint DB_REP_REREQUEST = 0x00000008;
        internal const int DB_REP_UNAVAIL = -30974;
        internal const int DB_REP_WRITE_FORWARD_TIMEOUT = 10;
        internal const uint DB_REVSPLITOFF = 0x00000100;
        internal const uint DB_RMW = 0x00002000;
        internal const int DB_RUNRECOVERY = -30972;
        internal const uint DB_SALVAGE = 0x00000040;
        internal const int DB_SECONDARY_BAD = -30971;
        internal const uint DB_SEQ_DEC = 0x00000001;
        internal const uint DB_SEQ_INC = 0x00000002;
        internal const uint DB_SEQ_WRAP = 0x00000008;
        internal const uint DB_SET = 26;
        internal const uint DB_SET_LOCK_TIMEOUT = 0x00000001;
        internal const uint DB_SET_RANGE = 27;
        internal const uint DB_SET_RECNO = 28;
        internal const uint DB_SET_TXN_TIMEOUT = 0x00000002;
        internal const uint DB_SNAPSHOT = 0x00000200;
        internal const uint DB_STAT_ALL = 0x00000004;
        internal const uint DB_STAT_ALLOC = 0x00000008;
        internal const uint DB_STAT_CLEAR = 0x00000001;
        internal const uint DB_STAT_LOCK_CONF = 0x00000010;
        internal const uint DB_STAT_LOCK_LOCKERS = 0x00000020;
        internal const uint DB_STAT_LOCK_OBJECTS = 0x00000040;
        internal const uint DB_STAT_LOCK_PARAMS = 0x00000080;
        internal const uint DB_STAT_MEMP_HASH = 0x00000010;
        internal const uint DB_STAT_SUBSYSTEM = 0x00000002;
        internal const uint DB_STREAM_READ = 0x00000001;
        internal const uint DB_STREAM_SYNC_WRITE = 0x00000004;
        internal const uint DB_STREAM_WRITE = 0x00000002;
        internal const uint DB_SYSTEM_MEM = 0x00080000;
        internal const uint DB_THREAD = 0x00000020;
        internal const int DB_TIMEOUT = -30969;
        internal const uint DB_TIME_NOTGRANTED = 0x00040000;
        internal const uint DB_TRUNCATE = 0x00080000;
        internal const uint DB_TXN_ABORT = 0;
        internal const uint DB_TXN_APPLY = 1;
        internal const uint DB_TXN_BACKWARD_ROLL = 3;
        internal const uint DB_TXN_BULK = 0x00000010;
        internal const uint DB_TXN_FORWARD_ROLL = 4;
        internal const uint DB_TXN_NOSYNC = 0x00000001;
        internal const uint DB_TXN_NOT_DURABLE = 0x00000004;
        internal const uint DB_TXN_NOWAIT = 0x00000002;
        internal const uint DB_TXN_PRINT = 7;
        internal const uint DB_TXN_SNAPSHOT = 0x00000004;
        internal const uint DB_TXN_SYNC = 0x00000008;
        internal const uint DB_TXN_TOKEN_SIZE = 20;
        internal const uint DB_TXN_WAIT = 0x00000080;
        internal const uint DB_TXN_WRITE_NOSYNC = 0x00000020;
        internal const uint DB_UNKNOWN = 5;
        internal const uint DB_UPGRADE = 0x00000001;
        internal const uint DB_USE_ENVIRON = 0x00000004;
        internal const uint DB_USE_ENVIRON_ROOT = 0x00000008;
        internal const uint DB_VERB_BACKUP = 0x00000001;
        internal const uint DB_VERB_DEADLOCK = 0x00000002;
        internal const uint DB_VERB_FILEOPS = 0x00000004;
        internal const uint DB_VERB_FILEOPS_ALL = 0x00000008;
        internal const uint DB_VERB_RECOVERY = 0x00000020;
        internal const uint DB_VERB_REGISTER = 0x00000040;
        internal const uint DB_VERB_REPLICATION = 0x00000080;
        internal const uint DB_VERB_REPMGR_CONNFAIL = 0x00000100;
        internal const uint DB_VERB_REPMGR_MISC = 0x00000200;
        internal const uint DB_VERB_REP_ELECT = 0x00000400;
        internal const uint DB_VERB_REP_LEASE = 0x00000800;
        internal const uint DB_VERB_REP_MISC = 0x00001000;
        internal const uint DB_VERB_REP_MSGS = 0x00002000;
        internal const uint DB_VERB_REP_SYNC = 0x00004000;
        internal const uint DB_VERB_REP_SYSTEM = 0x00008000;
        internal const uint DB_VERB_REP_TEST = 0x00010000;
        internal const uint DB_VERB_WAITSFOR = 0x00040000;
        internal const uint DB_VERIFY = 0x00000002;
        internal const int DB_VERIFY_BAD = -30968;
        internal const uint DB_VERSION_FAMILY = 12;
        internal const string DB_VERSION_FAMILY_STR = "12";
        internal const uint DB_VERSION_RELEASE = 1;
        internal const string DB_VERSION_RELEASE_STR = "1";
        internal const uint DB_VERSION_MAJOR = 6;
        internal const string DB_VERSION_MAJOR_STR = "6";
        internal const uint DB_VERSION_MINOR = 2;
        internal const string DB_VERSION_MINOR_STR = "2";
        internal const int DB_VERSION_MISMATCH = -30967;
        internal const uint DB_VERSION_PATCH = 23;
        internal const string DB_VERSION_PATCH_STR = "23";
        internal const string DB_VERSION_STRING = "Berkeley DB 6.2.23: March 28 2016 ";
        internal const string DB_VERSION_FULL_STRING = "Berkeley DB 12c Release 1 library version 12.1.6.2.23: March 28 2016 ";
        internal const uint DB_WRITECURSOR = 0x00000010;
        internal const uint DB_YIELDCPU = 0x00080000;
        internal const uint DB_USERCOPY_GETDATA = 0x00000001;
        internal const uint DB_USERCOPY_SETDATA = 0x00000002;
    }
}

// end of DbConstants.cs
