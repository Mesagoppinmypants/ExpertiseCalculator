## Author: Iosnowore Kun
; MrEdInstaller.nsi
;------------------

; For Modern UI
!include "MUI.nsh"

; The name of the installer
Name "Project SWG Tools Installer"

; The file to write
OutFile "ToolsInstaller.exe"

; Icon for installer
!define MUI_ICON "256.ico"
;!define MUI_HEADERIMAGE
;!define MUI_HEADERIMAGE_BITMAP "LOGO256X256.bmp"
;!define MUI_HEADERIMAGE_RIGHT
;!define MUI_WELCOMEFINISHPAGE_BITMAP ".bmp"

; The default installation directory
InstallDir $PROGRAMFILES\ProjectSWGTools

; Request application privileges for Windows Vista
RequestExecutionLevel highest

; Overwrite old folder
InstallDirRegKey HKCU "Software\ProjectSWGTools" ""

;--------------------------------
; Pages

# Install Pages
!insertmacro MUI_PAGE_WELCOME
;!insertmacro MUI_PAGE_LICENSE "license.txt"
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

# Uninstall Pages
!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH

;--------------------------------
; Language - English only for now - Added to fix language errors
 
!insertmacro MUI_LANGUAGE "English"

; Install
Section "Project SWG Tools"
  SectionIn RO
;Installer

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File ProjectSWGTools.exe
  File /r "sound"
  
  ; Stores installation folder
  WriteRegStr HKCU "Software\ProjectSWGTools" "" $INSTDIR
  
  ; Creates uninstall application
  WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd

  SectionGroup /e "Create Shortcuts"
    Section "on Desktop" SectionX
	  SetShellVarContext current
      CreateShortCut "$DESKTOP\Project SWG Tools.lnk" "$INSTDIR\ProjectSWGTools.exe"
    SectionEnd
	Section "in Start Menu" SectionY
	  CreateShortCut "$SMPROGRAMS\Project SWG Tools.lnk" "$INSTDIR\ProjectSWGTools.exe"
	SectionEnd
  SectionGroupEnd
  
Section "Uninstall"
;Uninstall

  ; Deletes the whole directory
  RMDir /r "$INSTDIR"
  
  ; Deletes the shortcuts
  Delete "$SMPROGRAMS\Project SWG Tools.lnk"
  Delete "$Desktop\Project SWG Tools.lnk"
  
  DeleteRegKey HKCU "Software\ProjectSWGTools"
  
  
SectionEnd ; end the section
