using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizDB : MonoBehaviour
{
    [SerializeField] private List<Question> m_questionlist = null;

    private List<Question> m_backup = null;

    private void Awake()
    {
        m_backup = m_questionlist;
    }

    public Question GetRandom(bool remove = true)
    {
        if (m_questionlist.Count == 0)
            RestoreBackup();
        
        int index = Random.Range(0, m_questionlist.Count);

        if (!remove)
            return m_questionlist(index);

        Question q = m_questionlist(index);
        m_questionlist.RemoveAt(index);

        return q;
    }
    private void RestoreBackup()
    {
        m_questionlist = m_backup;
    }
}
