using System.Collections.Generic;

namespace SystemInfo_v2
{
    public class ClassesTurkishName
    {
        public Dictionary<string, string> Names = new Dictionary<string, string>()
        {

            {"Win32_1394Controller", "IEEE 1394 (FireWire) Denetleyicisi"},
            {"Win32_Fan", "Fan"},
            {"Win32_PerfFormattedData_PerfOS_Memory","Bellek Kullanımı" },
            {"Win32_PerfFormattedData_PerfDisk_LogicalDisk","Disk Kullanımı" },
            {"Win32_PerfRawData_Tcpip_NetworkInterface","Ağ Trafiği" },
            {"Win32_Product", "Yazılım Ürünleri hakkında genel bilgi" },
            {"Win32_HeatPipe", "Isı Borusu"},
            {"Win32_Refrigeration", "Soğutma"},
            {"Win32_TemperatureProbe", "Sıcaklık Sensörü"},
            {"Win32_AssociatedProcessorMemory", "İlişkili İşlemci Belleği"},
            {"Win32_AutochkSetting", "Autochk Ayarı"},
            {"Win32_BaseBoard", "Anakart"},
            {"Win32_Battery", "Batarya"},
            {"Win32_BIOS", "BIOS"},
            {"Win32_Bus", "Veri Yolu"},
            {"Win32_CacheMemory", "Önbellek Belleği"},
            {"Win32_CDROMDrive", "CD ROM Sürücüsü"},
            {"Win32_CIMLogicalDeviceCIMDataFile", "CIM Mantıksal Aygıt CIM Veri Dosyası"},
            {"Win32_ComputerSystemProcessor", "Bilgisayar Sistemi İşlemcisi"},
            {"Win32_CurrentProbe", "Akım Sensörü"},
            {"Win32_DesktopMonitor", "Masaüstü Monitörü"},
            {"Win32_DeviceBus", "Aygıt Veri Yolu"},
            {"Win32_DeviceChangeEvent", "Aygıt Değişikliği Olayı"},
            {"Win32_DeviceMemoryAddress", "Aygıt Bellek Adresi"},
            {"Win32_DeviceSettings", "Aygıt Ayarları"},
            {"Win32_DiskDrive", "Disk Sürücüsü"},
            {"Win32_DiskDriveToDiskPartition", "Disk Sürücüsü - Disk Bölümü İlişkisi"},
            {"Win32_DiskPartition", "Disk Bölümü"},
            {"Win32_DisplayControllerConfiguration", "Ekran Denetleyicisi Yapılandırması"},
            {"Win32_DMAChannel", "DMA Kanalı"},
            {"Win32_DriverForDevice", "Aygıt İçin Sürücü"},
            {"Win32_FloppyController", "Disket Sürücü Denetleyicisi"},
            {"Win32_FloppyDrive", "Disket Sürücüsü"},
            {"Win32_IDEController", "IDE Denetleyicisi"},
            {"Win32_IDEControllerDevice", "IDE Denetleyicisine Bağlı Aygıt"},
            {"Win32_InfraredDevice", "Infrared Aygıtı"},
            {"Win32_IRQResource", "IRQ Kaynağı"},
            {"Win32_Keyboard", "Klavye"},
            {"Win32_LogicalDisk", "Mantıksal Disk"},
            {"Win32_LogicalDiskRootDirectory", "Mantıksal Disk Kök Dizini"},
            {"Win32_LogicalDiskToPartition", "Mantıksal Disk - Disk Bölümü İlişkisi"},
            {"Win32_LogicalProgramGroup", "Mantıksal Program Grubu"},
            {"Win32_LogicalProgramGroupDirectory", "Mantıksal Program Grubu Dizini"},
            {"Win32_LogicalProgramGroupItem", "Mantıksal Program Grubu Öğesi"},
            {"Win32_LogicalProgramGroupItemDataFile", "Mantıksal Program Grubu Öğesi Veri Dosyası"},
            {"Win32_MappedLogicalDisk", "Eşlenmiş Mantıksal Disk"},
            {"Win32_MemoryArray", "Bellek Grubu"},
            {"Win32_MemoryArrayLocation", "Bellek Grubu Konumu"},
            {"Win32_MemoryDevice", "Bellek Aygıtı"},
            {"Win32_MemoryDeviceArray", "Bellek Aygıtı Grubu"},
            {"Win32_MemoryDeviceLocation", "Bellek Aygıtı Konumu"},
            {"Win32_MotherboardDevice", "Anakart Aygıtı"},
            {"Win32_NetworkAdapter", "Ağ Bağdaştırıcısı"},
            {"Win32_NetworkAdapterConfiguration", "Ağ Bağdaştırıcısı Yapılandırması"},
            {"Win32_NetworkAdapterSetting", "Ağ Bağdaştırıcısı Ayarı"},
            {"Win32_NetworkClient", "Ağ İstemcisi"},
            {"Win32_NetworkConnection", "Ağ Bağlantısı"},
            {"Win32_NetworkLoginProfile", "Ağ Giriş Profili"},
            {"Win32_NetworkProtocol", "Ağ Protokolü"},
            {"Win32_OnBoardDevice", "Anakart Üzerindeki Aygıt"},
            {"Win32_ParallelPort", "Paralel Bağlantı Noktası"},
            {"Win32_PCMCIAController", "PCMCIA Denetleyicisi"},
            {"Win32_PhysicalMemory", "Fiziksel Bellek"},
            {"Win32_PhysicalMemoryArray", "Fiziksel Bellek Grubu"},
            {"Win32_PhysicalMemoryLocation", "Fiziksel Bellek Konumu"},
            {"Win32_PnPAllocatedResource", "PnP Tahsis Edilen Kaynak"},
            {"Win32_PnPDevice", "PnP Aygıtı"},
            {"Win32_PnPDeviceProperty", "PnP Aygıt Özelliği"},
            {"Win32_PnPEntity", "PnP Varlığı"},
            {"Win32_PointingDevice", "İşaret Cihazı"},
            {"Win32_PortableBattery", "Taşınabilir Batarya"},
            {"Win32_PortConnector", "Port Bağlayıcı"},
            {"Win32_PortResource", "Port Kaynağı"},
            {"Win32_POTSModem", "POTS Modemi"},
            {"Win32_POTSModemToSerialPort", "POTS Modemden Seri Bağlantı Noktasına"},
            {"Win32_Printer", "Yazıcı"},
            {"Win32_PrinterConfiguration", "Yazıcı Yapılandırması"},
            {"Win32_PrinterController", "Yazıcı Kontrolcüsü"},
            {"Win32_PrinterDriver", "Yazıcı Sürücüsü"},
            {"Win32_PrinterDriverDll", "Yazıcı Sürücüsü DLL'si"},
            {"Win32_PrinterSetting", "Yazıcı Ayarı"},
            {"Win32_PrinterShare", "Yazıcı Paylaşımı"},
            {"Win32_PrintJob", "Yazdırma İşi"},
            {"Win32_Processor", "İşlemci"},
            {"Win32_SCSIController", "SCSI Denetleyicisi"},
            {"Win32_SCSIControllerDevice", "SCSI Denetleyicisi Aygıtı"},
            {"Win32_SerialPort", "Seri Bağlantı Noktası"},
            {"Win32_SerialPortConfiguration", "Seri Bağlantı Noktası Yapılandırması"},
            {"Win32_SerialPortSetting", "Seri Bağlantı Noktası Ayarları"},
            {"Win32_SMBIOSMemory", "SMBIOS Belleği"},
            {"Win32_SoundDevice", "Ses Aygıtı"},
            {"Win32_TapeDrive", "Bant Sürücüsü"},
            {"Win32_TCPIPPrinterPort", "TCP/IP Yazıcı Bağlantı Noktası"},
            {"Win32_USBController", "USB Denetleyicisi"},
            {"Win32_USBControllerDevice", "USB Denetleyici Aygıtı"},
            {"Win32_VideoController", "Video Denetleyicisi"},
            {"Win32_VideoSettings", "Video Ayarları"},
            {"Win32_VoltageProbe", "Gerilim Probu"}
        };
    }
}

