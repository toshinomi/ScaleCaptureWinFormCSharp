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

    /// <summary>
    /// ビットマップ
    /// </summary>
    public Bitmap bitmap
    {
        get { return (Bitmap)m_bitmap.Clone(); }
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public ScaleNearestNeighbor()
    {
    }

    /// <summary>
    /// デスクトラクタ
    /// </summary>
    ~ScaleNearestNeighbor()
    {
    }

    /// <summary>
    /// 初期化
    /// </summary>
    public void Init()
    {
        m_bitmap = null;
    }

    /// <summary>
    /// 最近傍補間法の実行
    /// </summary>
    /// <param name="_bitmap">ビットマップ</param>
    /// <param name="_fScale">スケール</param>
    /// <returns>実行結果 成功/失敗</returns>
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