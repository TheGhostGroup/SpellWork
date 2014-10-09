﻿using DBFilesClient.NET;

namespace SpellWork.DBC.Structures
{
    public sealed class SkillLineAbilityEntry
    {
        public uint Id;                                             // 0        m_ID
        public uint SkillId;                                        // 1        m_skillLine
        public uint SpellId;                                        // 2        m_spell
        public uint Racemask;                                       // 3        m_raceMask
        public uint Classmask;                                      // 4        m_classMask
        public uint ReqSkillValue;                                  // 7        m_minSkillLineRank
        public uint ForwardSpellid;                                 // 8        m_supercededBySpell
        public uint LearnOnGetSkill;                                // 9        m_acquireMethod
        public uint MaxValue;                                       // 10       m_trivialSkillLineRankHigh
        public uint MinValue;                                       // 11       m_trivialSkillLineRankLow
        public uint CharacterPoints;                              // 12       m_characterPoints
        public uint unk0;
        public uint unk1;
    }
}
