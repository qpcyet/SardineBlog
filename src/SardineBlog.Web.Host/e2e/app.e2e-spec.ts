import { SardineBlogTemplatePage } from './app.po';

describe('SardineBlog App', function() {
  let page: SardineBlogTemplatePage;

  beforeEach(() => {
    page = new SardineBlogTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
