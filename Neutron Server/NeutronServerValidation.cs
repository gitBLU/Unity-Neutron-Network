﻿using System;

public class NeutronServerValidation : NeutronServerConstants
{
    public void ExecuteValidation(ValidationPacket vType, NeutronReader paramsReader, Player mSocket)
    {
        using (paramsReader)
        {
            try
            {
                switch (vType)
                {
                    case ValidationPacket.Movement:
                        CustomServerValidation.ServerMovementValidation(paramsReader, mSocket); // Don't change that.
                        break;
                    case ValidationPacket.None:
                        // Your custom validation script.
                        break;
                }
            }
            catch (Exception ex)
            {
                NeutronServerFunctions.SendDisconnect(mSocket, ex.Message);
                return; // Return to prevent sending to other players. do not use return within the queue (DO NOT WORK).
            }
        }
    }
}