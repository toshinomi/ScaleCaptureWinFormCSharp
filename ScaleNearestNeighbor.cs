using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

class ScaleNearestNeighbor
{
    private Bitmap      m_bitmap;
    private ProgressBar m_progressBar;
    public Bitmap bitmap
    {
        get { return (Bitmap)m_bitmap.Clone(); }
    }
    public ProgressBar progressBar
    {
        set { m_progressBar = value; }
    }

    public ScaleNearestNeighbor()
    {
    }

    ~ScaleNearestNeighbor()
    {
    }

    public void Init()
    {
        m_bitmap = null;
    }

    public bool GoImgProc(Bitmap _bitmap,  float _fScale)
    {
        bool bRst = true;

        int nWidthSize = (int)(_bitmap.Width * _fScale);
        int nHeightSize = (int)(_bitmap.Height * _fScale);

        m_bitmap = new Bitmap(nWidthSize, nHeightSize);

        BitmapData bitmapDataOrg = _bitmap.LockBits(new Rectangle(0, 0, _bitmap.Width, _bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
        BitmapData bitmapDataAfter = m_bitmap.LockBits(new Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

        int nIdxWidth;
        int nIdxHeight;
        int nCount = 0;

        unsafe
        {
            for (nIdxHeight = 0; nIdxHeight < nHeightSize; nIdxHeight++)
            {
                for (nIdxWidth = 0; nIdxWidth < nWidthSize; nIdxWidth++)
                {
                    int nWidth = (int)Math.Round(nIdxWidth / _fScale);
                    int nHeight = (int)Math.Round(nIdxHeight / _fScale);

                    if (nWidth < _bitmap.Width && nHeight < _bitmap.Height)
                    {

                        byte* pPixelOrg = (byte*)bitmapDataOrg.Scan0 + nHeight * bitmapDataOrg.Stride + nWidth * 4;
                        byte* pPixelAfter = (byte*)bitmapDataAfter.Scan0 + nIdxHeight * bitmapDataAfter.Stride + nIdxWidth * 4;


                        pPixelAfter[(int)ComInfo.Pixel.B] = pPixelOrg[(int)ComInfo.Pixel.B];
                        pPixelAfter[(int)ComInfo.Pixel.G] = pPixelOrg[(int)ComInfo.Pixel.G];
                        pPixelAfter[(int)ComInfo.Pixel.R] = pPixelOrg[(int)ComInfo.Pixel.R];
                        pPixelAfter[(int)ComInfo.Pixel.A] = pPixelOrg[(int)ComInfo.Pixel.A];

                        nCount++;
                    }
                }
            }
            _bitmap.UnlockBits(bitmapDataOrg);
            m_bitmap.UnlockBits(bitmapDataAfter);
        }

        return bRst;
    }
}