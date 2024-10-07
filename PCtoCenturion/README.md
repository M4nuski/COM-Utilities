# PC to Centurion

Serial COM port data transfer utility

Can load :
- RAW sector data, stride of 512 ( 400 bytes of data, padded to 512 bytes blocks )
- FinchDump sector data, stride of 419 ( "FinchDump\r\n" header, 4 bytes sector number, 400 bytes of data, 2 bytes CRC, "\r\n" )
- HawkDump sector data, stride of 416 (WIP - NOT TESTED)  ( "HawkDump\r\n" header, 2 bytes sector number, 400 bytes of data, 2 bytes CRC, "\r\n" )

CRC is computed for each block of 400 using the CRC-16/XMODEM (similar to CRC-CCITT)

To use :
- Select COM port and settings, [Open Device]
- [Load data file]
- [Begin Send]
  - The program will send 0xFF repeatedly to the Centurion waiting for 0xFF to start
  - Then each 400 sector data + the 2 bytes of CRC
  - Wait until 0xFF (ACK) or 0x00 (NACK)
    - On ACK proceed to the next sector
    - On NACK resend the same sector up to 10 times

- The program is a state machine so [Abort Send] need to be clicked to reload another file or restart sending again.


