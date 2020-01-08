using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    enum Area
    {
        Center = 0,
        Jerursalem,
        South,
        North
    }
    enum Pool
    {
        Might = 0,
        Must,
        NotInterested
    }
    enum Type
    {
        Zimmer = 0,
        Hottel,
        Mottel,
        Camping
    }
    enum ChildrenAtraction
    {
        Might = 0,
        Must,
        NotInterested
    }
    enum Jacuzzi
    {
        Might = 0,
        Must,
        NotInterested
    }
    enum Garden
    {
        Might = 0,
        Must,
        NotInterested
    }
    enum CollectionClearance
    {
        Yes = 0,
        No
    }
    enum Status
    {
        NotYetBeAchived = 0,
        MailSent,
        ClosedBecauseTheClient,
        ClosedNotBecauseTheClient
    }
}
